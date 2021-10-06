using NaitonGps.Models;
using NaitonGps.Services;
using NaitonGps.ViewModels;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NaitonGps.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstRoleTemplate : Grid
    {
        public FirstRoleTemplate()
        {
            InitializeComponent();
            BindingContext = new PickListViewModel();
        }

        public async void move()
        {
            await ContentContainer.TranslateTo(0, -300, 30, Easing.Linear);
            await Header.TranslateTo(0, -300, 30, Easing.Linear);
            Header.IsVisible = true;
            ContentContainer.IsVisible = true;
            await Header.TranslateTo(0, 0, 500);
            await ContentContainer.TranslateTo(0, 0, 300);
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await App.Current.MainPage.DisplayAlert("", "Scanner", "Ok");
        }

        private async void PicklistContentPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PicklistContent());
        }

    }
}