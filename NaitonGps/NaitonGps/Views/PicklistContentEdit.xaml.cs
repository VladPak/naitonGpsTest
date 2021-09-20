using Rg.Plugins.Popup.Services;
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
    public partial class PicklistContentEdit : ContentPage
    {
        public string modeResult = Preferences.Get("userMode", string.Empty);

        public PicklistContentEdit()
        {
            CloseAllPopup();
            InitializeComponent();

            switch (modeResult)
            {
                case "readOnly":
                    gridToHide.IsVisible = false;
                    break;
                case "readAndEdit":
                    gridToHide.IsVisible = true;
                    break;
                default:
                    gridToHide.IsVisible = true;
                    DisplayAlert("", "Server error. Please contact app development team", "Ok");
                    break;
            }
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            DisplayAlert("", "Label clicked", "Ok");
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            DisplayAlert("", "Save N Print", "Ok");
        }

        public async void CloseAllPopup()
        {
            await PopupNavigation.Instance.PopAllAsync();
        }
    }
}