﻿using NaitonGps.Models;
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
        public static double screenWidth { get; } = DeviceDisplay.MainDisplayInfo.Width;
        public static bool isSmallScreen { get; } = screenWidth <= 480;
        public static bool isBigScreen { get; } = screenWidth >= 480;

        public FirstRoleTemplate()
        {
            InitializeComponent();
            BindingContext = new PickListViewModel();

            if (isSmallScreen)
            {
                MajorGrid.Margin = new Thickness(5, 20, 5, 20);
                rowToAdjust.Height = new GridLength(0.7, GridUnitType.Star);
                
            }
            else if (isBigScreen)
            {
                MajorGrid.Margin = new Thickness(10, 0, 10, 10);
                rowToAdjust.Height = new GridLength(0.4, GridUnitType.Star);
            }
            move();
        }

        private async void PopUpSample(object sender, EventArgs e)
        {
            await Navigation.PushPopupAsync(new MorePopUp());
        }

        public async void move()
        {
            //await ContentContainer.TranslateTo(0, -300, 30, Easing.Linear);
            //await Header.TranslateTo(0, -300, 30, Easing.Linear);
            //Header.IsVisible = true;
            //ContentContainer.IsVisible = true;
            //await Header.TranslateTo(0, 0, 500);
            //await ContentContainer.TranslateTo(0, 0, 300);
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PicklistContent());
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            
        }
    }
}