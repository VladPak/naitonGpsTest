using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NaitonGps.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginScreenNaitonBigScreen : ContentPage
    {
        public LoginScreenNaitonBigScreen()
        {
            InitializeComponent();
            imgBackground.ScaleX = 1;
            imgBackground.ScaleY = 1;
            imgLogo.TranslationY = 100;
            frameLogin.TranslationY = 450;
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await imgBackground.ScaleTo(1.2, 90, Easing.Linear);
            await imgLogo.TranslateTo(0, -100, 280, Easing.Linear);
            await frameLogin.TranslateTo(0, 0, 330, Easing.Linear);
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            DisplayAlert("", "Terms of Service is clicked", "Ok");
        }
    }
}