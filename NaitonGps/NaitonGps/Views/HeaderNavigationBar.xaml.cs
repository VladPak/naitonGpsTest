using Rg.Plugins.Popup.Extensions;
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
	public partial class HeaderNavigationBar : Grid
	{
		public HeaderNavigationBar ()
		{
			InitializeComponent ();
		}

		private async void PopUpSample(object sender, EventArgs e)
		{
			await Navigation.PushPopupAsync(new MorePopUp());
		}
	}
}