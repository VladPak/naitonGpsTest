using NaitonGps.ViewModels;
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
    public partial class PicklistContent : ContentPage
    {
        public PicklistContent()
        {
            InitializeComponent();
            BindingContext = new PicklistContentDataViewModel();

        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            await DisplayAlert("", "The filter btn clicked", "Ok");
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            DisplayAlert("", "Call popUp", "Ok");
        }

        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            DisplayAlert("", "The item is clicked`", "Ok");
        }
    }
}