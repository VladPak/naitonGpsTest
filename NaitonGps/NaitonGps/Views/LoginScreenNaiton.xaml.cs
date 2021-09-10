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
    public partial class LoginScreenNaiton : ContentPage
    {


        public LoginScreenNaiton()
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
            await imgLogo.TranslateTo(0, -50, 280, Easing.Linear);
            await frameLogin.TranslateTo(0, 0, 330, Easing.Linear);
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            //DisplayAlert("", "Terms of Service is clicked", "Ok");
            await Navigation.PushModalAsync(new TermsAndServices());
        }
    }
}