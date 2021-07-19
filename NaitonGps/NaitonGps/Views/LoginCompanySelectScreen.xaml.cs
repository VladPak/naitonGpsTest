using NaitonGps.Services;
using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NaitonGps.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginCompanySelectScreen : ContentPage
    {
        public LoginCompanySelectScreen()
        {
            InitializeComponent();
        }

        private async void TabCompanySelect_Tapped(object sender, EventArgs e)
        {
            if (CrossConnectivity.Current.IsConnected)
            {
                Preferences.Set("loginCompany", entCompany.Text);
                var response = await ApiService.GetWebService(entCompany.Text);

                //Call Web service
                if (response)
                {
                    await DisplayAlert("", "Company exists. You may log in", "Ok");
                    //Redirect to the page
                    await Navigation.PushModalAsync(new LoginEmailScreen());
                }
                else
                {
                    await DisplayAlert("", "Company does not exist. Please enter valid company name", "Ok");
                }
            }
            else
            {
                await DisplayAlert("", "Check the Internet connection.", "Ok");
            }
        }
    }
}