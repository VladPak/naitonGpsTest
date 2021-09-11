using NaitonGps.Views;
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

        public App()
        {
            InitializeComponent();

            if (isSmallScreen)
            {
                //var nav = new NavigationPage(new LoginCompanySelectScreen());
                var nav = new NavigationPage(new LoginScreenNaiton());
                MainPage = nav;
            }
            else if (isBigScreen)
            {
                //var nav = new NavigationPage(new LoginCompanySelectScreen());
                var nav = new NavigationPage(new LoginScreenNaitonBigScreen());
                MainPage = nav;
            }

            //var nav = new NavigationPage(new LoginCompanySelectScreen());

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
