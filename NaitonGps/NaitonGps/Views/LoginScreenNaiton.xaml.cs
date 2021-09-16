using NaitonGps.Services;
using Plugin.Connectivity;
using SimpleWSA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NaitonGps.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginScreenNaiton : ContentPage
    {
        int taps = 0;
        
        public LoginScreenNaiton()
        {
            InitializeComponent();
            scrollToActivate.IsEnabled = false;
            //imgBackground.ScaleX = 1;
            //imgBackground.ScaleY = 1;
            imgLogo.TranslationY = 100;
            frameLogin.TranslationY = 450;            
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            //await imgBackground.ScaleTo(1.2, 90, Easing.Linear);
            await imgLogo.TranslateTo(0, -20, 280, Easing.Linear);
            await frameLogin.TranslateTo(0, 0, 330, Easing.Linear);
            scrollToActivate.IsEnabled = true;
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            //await Navigation.PushModalAsync(new TermsAndServices());
        }

        private async void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            if (CrossConnectivity.Current.IsConnected)
            {
                Preferences.Set("loginCompany", entCompany.Text);
                Preferences.Set("loginEmail", entEmail.Text);
                //Call Web service
                taps++;
                var response = await ApiService.GetWebService(entCompany.Text);

                if (response)
                {
                    if (taps == 1)
                    {
                        //Login with email and password
                        //await Navigation.PushModalAsync(new LoginEmailScreen(), true);

                        var userEmail = Preferences.Get("loginEmail", string.Empty);
                        var emailPattern = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
                        var providerPattern = @"\b(naitongps)\b";
                        var webServiceName = Preferences.Get("loginCompany", string.Empty);
                        var userPassword = entPassword.Text;

                        if (CrossConnectivity.Current.IsConnected)
                        {
                            if (string.IsNullOrEmpty(userPassword) || userPassword != "Gromit12")
                            {
                                await DisplayAlert("", "Invalid password", "Ok");
                            }
                            else
                            {
                                if (Regex.IsMatch(userEmail, emailPattern))
                                {
                                    if (Regex.IsMatch(webServiceName, providerPattern))
                                    {
                                        //var checkAccess = Preferences.Get("loginCompany", string.Empty);
                                        //var response = await ApiService.Login(userEmail, entPassword.Text);

                                        var domain = Preferences.Get("loginCompany", string.Empty);
                                        var webserviceLink = Preferences.Get("webservicelink", string.Empty);
                                        string currentAppVersion = VersionTracking.CurrentVersion;

                                        Session session = new Session(userEmail,
                                                                      entPassword.Text,
                                                                      false,
                                                                      4,
                                                                      currentAppVersion,
                                                                      "naitongps",
                                                                      null);
                                        await session.CreateByConnectionProviderAddressAsync("https://connectionprovider.naiton.com/");

                                        //if ()
                                        //{
                                        //Application.Current.MainPage = new MainPage();
                                        Preferences.Set("token", SessionContext.Token);
                                        Application.Current.MainPage = new MainNavigationPage();
                                        //}
                                        //else
                                        //{
                                        //    await DisplayAlert("", "You have problems with Web Service. Please contact the support center", "Ok");
                                        //}
                                    }
                                    else
                                    {
                                        await DisplayAlert("", "Only naitongps users allowed", "Ok");
                                    }
                                }
                                else if (string.IsNullOrWhiteSpace(userPassword))
                                {
                                    await DisplayAlert("", "Password field is empty", "Ok");
                                }
                                else if (!Regex.IsMatch(userEmail, emailPattern))
                                {
                                    await DisplayAlert("", "Wrong email format", "Ok");
                                }
                                else
                                {
                                    await DisplayAlert("", "Email or password input error.", "Ok");
                                }
                            }
                        }
                        else
                        {
                            await DisplayAlert("", "Check the Internet connection.", "Ok");
                        }


                        entCompany.Text = string.Empty;
                        taps = 0;
                    }
                    else if (taps >= 2)
                    {
                        taps = 0;
                        await DisplayAlert("", "Please wait. Your request is being proceeded", "Ok");
                    }
                }
                else
                {
                    await DisplayAlert("", "Company does not exist. Please enter valid company name", "Ok");
                    entCompany.Text = string.Empty;
                    taps = 0;
                }
            }
            else
            {
                await DisplayAlert("", "Check the Internet connection.", "Ok");
                taps = 0;
            }
        }
    }
}