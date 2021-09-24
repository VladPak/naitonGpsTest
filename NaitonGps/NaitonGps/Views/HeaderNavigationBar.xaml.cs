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
	public partial class HeaderNavigationBar : Grid
	{
		public static double screenWidth { get; } = DeviceDisplay.MainDisplayInfo.Width;
		public static bool isSmallScreen { get; } = screenWidth <= 480;
		public static bool isBigScreen { get; } = screenWidth >= 480;

		public HeaderNavigationBar ()
		{
			InitializeComponent ();

			if (isSmallScreen)
			{
				iconUser.HeightRequest = 25;
				iconUser.WidthRequest = 25;

				iconNotification.HeightRequest = 25;
				iconNotification.WidthRequest = 25;
			}
			else if (isBigScreen)
			{
				iconUser.HeightRequest = 30;
				iconUser.WidthRequest = 30;

				iconNotification.HeightRequest = 30;
				iconNotification.WidthRequest = 30;
			}
		}

		private async void PopUpSample(object sender, EventArgs e)
		{
			await Navigation.PushPopupAsync(new MorePopUp());
		}

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }
    }
}