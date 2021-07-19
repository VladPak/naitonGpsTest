using NaitonGps.ViewModels;
using Rg.Plugins.Popup.Extensions;
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
    public partial class FirstRoleTemplate : Grid
    {
        public UserViewModel allUsers;

        public FirstRoleTemplate()
        {
            InitializeComponent();
            lblUserEmail.Text = Preferences.Get("loginEmail", string.Empty);
        }

        private async void PopUpSample(object sender, EventArgs e)
        {
            await Navigation.PushPopupAsync(new MorePopUp());
        }

        public async void move()
        {
            await mainGrid.Children[0].TranslateTo(0, 200, 200, Easing.Linear);
            await mainGrid.Children[0].TranslateTo(0, 0);
            await mainGrid.Children[1].TranslateTo(0, 200, 200, Easing.Linear);
            await mainGrid.Children[1].TranslateTo(0, 0);
        }

    }
}