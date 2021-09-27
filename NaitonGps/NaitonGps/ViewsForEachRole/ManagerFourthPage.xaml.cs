using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NaitonGps.ViewsForEachRole
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ManagerFourthPage : Grid
    {
        public static double screenWidth { get; } = DeviceDisplay.MainDisplayInfo.Width;
        public static bool isSmallScreen { get; } = screenWidth <= 480;
        public static bool isBigScreen { get; } = screenWidth >= 480;

        public ManagerFourthPage()
        {
            InitializeComponent();

            //if (isSmallScreen)
            //{
            //    MajorGrid.Margin = new Thickness(5, 20, 5, 20); ;
            //}
            //else if (isBigScreen)
            //{
            //    MajorGrid.Margin = new Thickness(10, 0, 10, 10); ;
            //}
        }
    }
}