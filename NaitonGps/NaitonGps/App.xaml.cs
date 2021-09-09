using NaitonGps.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NaitonGps
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //var nav = new NavigationPage(new LoginCompanySelectScreen());
            var nav = new NavigationPage(new LoginScreenNaiton());
            MainPage = nav;
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
