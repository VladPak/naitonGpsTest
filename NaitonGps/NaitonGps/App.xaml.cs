using NaitonGps.Models;
using NaitonGps.Views;
using Newtonsoft.Json;
using SimpleWSA;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NaitonGps
{
    public partial class App : Application
    {
        public static double screenWidth { get; } = DeviceDisplay.MainDisplayInfo.Width;
        public static bool isSmallScreen { get; } = screenWidth <= 480;
        public static bool isBigScreen { get; } = screenWidth >= 480;


        public  App()
        {
            InitializeComponent();

            bool isLoggedIn = Current.Properties.ContainsKey("IsLoggedIn") ? Convert.ToBoolean(Current.Properties["IsLoggedIn"]) : false;

            if (isSmallScreen)
            {
                if (!isLoggedIn)
                {
                    var nav = new NavigationPage(new LoginScreenNaiton());
                    MainPage = nav;
                }
                else
                {

                    var nav = new NavigationPage(new MainNavigationPage());
                    MainPage = nav;
                }
            }
            else if (isBigScreen)
            {
                if (!isLoggedIn)
                {
                    var nav = new NavigationPage(new LoginScreenNaitonBigScreen());
                    MainPage = nav;
                }
                else
                {
                    while (true)
                    {
                        try
                        {
                            UserLoginDetails userData = JsonConvert.DeserializeObject<UserLoginDetails>((string)App.Current.Properties["UserDetail"]);

                            string currentAppVersion = VersionTracking.CurrentVersion;

                            Session session = new Session(userData.userEmail,
                                                            userData.userPassword,
                                                            userData.isEncrypted,
                                                            userData.appId,
                                                            userData.appVersion,
                                                            userData.domain,
                                                            
                                                            null);

                             session.CreateByConnectionProviderAddressAsync(userData.restServiceAddress);
                            var nav = new NavigationPage(new MainNavigationPage());
                            MainPage = nav;
                            break;
                        }
                        catch (Exception ex)
                        {
                             
                            break;
                        }
                    }


                }
            }
        }

        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {

        }

        protected override void OnResume()
        {

        }
    }
}
