﻿using NaitonGps.Models;
using NaitonGps.ViewModels;
using NaitonGps.ViewsForEachRole;
using NaitonGps.ViewsForEachRole.Driver;
using NaitonGps.ViewsForEachRole.SalesExecutive;
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
using Xamarin.CommunityToolkit.Markup;
using Plugin.CrossPlatformTintedImage.Abstractions;

namespace NaitonGps.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainNavigationPage : ContentPage
    {
        public ObservableCollection<UserViewModel> allRecords { get; set; } = new ObservableCollection<UserViewModel>();
        public int maxIndex = 2;
        public int minIndex = 0;
        private int templateIndex;
        private int selectedIndex;

        //Main pages for each role
        ControlTemplate template1 = new ControlTemplate(typeof(FirstRoleTemplate));
        ControlTemplate template2 = new ControlTemplate(typeof(SecondRoleTemplate));
        ControlTemplate template3 = new ControlTemplate(typeof(ThirdRoleTemplate));
        //Roles' pages 
        ControlTemplate template11 = new ControlTemplate(typeof(ManagerSecondPage));
        ControlTemplate template12 = new ControlTemplate(typeof(ManagerThirdPage));
        ControlTemplate template13 = new ControlTemplate(typeof(ManagerFourthPage));
        ControlTemplate template14 = new ControlTemplate(typeof(ManagerFifthPage));
        ControlTemplate template21 = new ControlTemplate(typeof(DriverSecondPage));
        ControlTemplate template22 = new ControlTemplate(typeof(DriverThirdPage));
        ControlTemplate template23 = new ControlTemplate(typeof(DriverFourthPage));
        ControlTemplate template24 = new ControlTemplate(typeof(DriverFifthPage));
        ControlTemplate template31 = new ControlTemplate(typeof(SalesExSecondPage));
        ControlTemplate template32 = new ControlTemplate(typeof(SalesExThirdPage));
        ControlTemplate template33 = new ControlTemplate(typeof(SalesExFourthPage));
        ControlTemplate template34 = new ControlTemplate(typeof(SalesExFifthPage));

        public static double screenWidth { get; } = DeviceDisplay.MainDisplayInfo.Width;
        public static bool isSmallScreen { get; } = screenWidth <= 360;
        public static bool isBigScreen { get; } = screenWidth >= 360;

        public MainNavigationPage()
        {
            InitializeComponent();
            ControlTemplate = template1;
            templateIndex = 0;
            selectedIndex = 0;
            BindingContext = new UserViewModel();

            //detect screen size and set margin between nav icons
            if (isSmallScreen)
            {
                bottomNavMenu.ColumnSpacing = 20;
            }
            else if (isBigScreen)
            {
                bottomNavMenu.ColumnSpacing = 30;
            }

            if (ControlTemplate == template1 || ControlTemplate == template2 || ControlTemplate == template3)
            {
                if (Application.Current.RequestedTheme == OSAppTheme.Light)
                {
                    txtItem1.TextColor = Color.Green;
                    navItem1.TintColor = Color.Green;
                    txtItem2.TextColor = Color.Black;
                    txtItem3.TextColor = Color.Black;
                    txtItem4.TextColor = Color.Black;
                    txtItem5.TextColor = Color.Black;
                    navItem2.TintColor = Color.Black;
                    navItem3.TintColor = Color.Black;
                    navItem4.TintColor = Color.Black;
                    navItem5.TintColor = Color.Black;
                }
                else if (Application.Current.RequestedTheme == OSAppTheme.Dark)
                {
                    txtItem1.TextColor = Color.Green;
                    navItem1.TintColor = Color.Green;
                    txtItem2.TextColor = Color.White;
                    txtItem3.TextColor = Color.White;
                    txtItem4.TextColor = Color.White;
                    txtItem5.TextColor = Color.White;
                    navItem2.TintColor = Color.White;
                    navItem3.TintColor = Color.White;
                    navItem4.TintColor = Color.White;
                    navItem5.TintColor = Color.White;
                }
            }

            Application.Current.RequestedThemeChanged += (s, a) =>
            {
                Label[] labels = new Label[] { txtItem1, txtItem2, txtItem3, txtItem4, txtItem5 };
                TintedImage[] images = new TintedImage[] { navItem1, navItem2, navItem3, navItem4, navItem5 };

                switch (a.RequestedTheme)
                {
                    case OSAppTheme.Dark:
                        foreach (var item in labels)
                        {
                            item.TextColor = Color.White;
                        }

                        foreach (var itemI in images)
                        {
                            itemI.TintColor = Color.White;
                        }

                        if (ControlTemplate == template1 || ControlTemplate == template2 || ControlTemplate == template3)
                        {
                            navItem1.TintColor = Color.Green;
                            txtItem1.TextColor = Color.Green;
                        }
                        else if (ControlTemplate == template11 || ControlTemplate == template21 || ControlTemplate == template31)
                        {
                            navItem2.TintColor = Color.Green;
                            txtItem2.TextColor = Color.Green;
                        }
                        else if (ControlTemplate == template12 || ControlTemplate == template22 || ControlTemplate == template32)
                        {
                            navItem3.TintColor = Color.Green;
                            txtItem3.TextColor = Color.Green;
                        }
                        else if (ControlTemplate == template13 || ControlTemplate == template23 || ControlTemplate == template33)
                        {
                            navItem4.TintColor = Color.Green;
                            txtItem4.TextColor = Color.Green;
                        }
                        else if (ControlTemplate == template14 || ControlTemplate == template24 || ControlTemplate == template34)
                        {
                            navItem5.TintColor = Color.Green;
                            txtItem5.TextColor = Color.Green;
                        }
                        break;
                    case OSAppTheme.Light:
                        foreach (var item in labels)
                        {
                            item.TextColor = Color.Black;
                        }

                        foreach (var itemG in images)
                        {
                            itemG.TintColor = Color.Black;
                        }

                        if (ControlTemplate == template1 || ControlTemplate == template2 || ControlTemplate == template3)
                        {
                            navItem1.TintColor = Color.Green;
                            txtItem1.TextColor = Color.Green;
                        }
                        else if (ControlTemplate == template11 || ControlTemplate == template21 || ControlTemplate == template31)
                        {
                            navItem2.TintColor = Color.Green;
                            txtItem2.TextColor = Color.Green;
                        }
                        else if (ControlTemplate == template12 || ControlTemplate == template22 || ControlTemplate == template32)
                        {
                            navItem3.TintColor = Color.Green;
                            txtItem3.TextColor = Color.Green;
                        }
                        else if (ControlTemplate == template13 || ControlTemplate == template23 || ControlTemplate == template33)
                        {
                            navItem4.TintColor = Color.Green;
                            txtItem4.TextColor = Color.Green;
                        }
                        else if (ControlTemplate == template14 || ControlTemplate == template24 || ControlTemplate == template34)
                        {
                            navItem5.TintColor = Color.Green;
                            txtItem5.TextColor = Color.Green;
                        }
                        break;
                    case OSAppTheme.Unspecified:
                        DisplayAlert("", "Unspecified OS Theme", "Ok");
                        break;
                }
            };
        }

        //Navigation controls
        //Previous Role (Swipe)
        private void SwipeGestureRecognizer_Swiped_PreviousRole(object sender, SwipedEventArgs e)
        {
            if (Device.RuntimePlatform == Device.Android)
            {
                DisplayAlert("", "Swipe navigation currently unavailable. Use arrow buttons please.", "Ok");
            }
            else if (Device.RuntimePlatform == Device.iOS)
            {
                PreviousContent();
                SwitchMenuImagesAndTxt();
                moveMenu();
            }

        }

        //Next Role (Swipe)
        private void SwipeGestureRecognizer_Swiped_NextRole(object sender, SwipedEventArgs e)
        {
            if (Device.RuntimePlatform == Device.Android)
            {
                DisplayAlert("", "Swipe navigation currently unavailable. Use arrow buttons please.", "Ok");
            }
            else if (Device.RuntimePlatform == Device.iOS)
            {
                NextContent();
                SwitchMenuImagesAndTxt();
                moveMenu();
            }
        }

        //Previous Role (Arrow button)
        private void TapGestureRecognizer_Tapped_PreviousRole(object sender, EventArgs e)
        {
            PreviousContent();
            SwitchMenuImagesAndTxt();
            moveMenu();
        }

        //Next Role (Arrow button)
        private void TapGestureRecognizer_Tapped_NextRole(object sender, EventArgs e)
        {
            NextContent();
            SwitchMenuImagesAndTxt();
            moveMenu();
        }

        //Navigation menu animation
        public async void moveMenu()
        {
            await bottomNavMenu.TranslateTo(0, 200, 200, Easing.Linear);
            await bottomNavMenu.TranslateTo(0, 0);
        }

        //Navigation functions
        public void NextContent()
        {
            selectedIndex = selectedIndex + 1;

            int indexCheck = templateIndex;
            if (indexCheck != selectedIndex && selectedIndex < maxIndex + 1)
            {
                switch (selectedIndex)
                {
                    case 0:
                        ControlTemplate = template1;
                        break;
                    case 1:
                        ControlTemplate = template2;
                        break;
                    case 2:
                        ControlTemplate = template3;
                        break;
                }
            }
            else if (selectedIndex > maxIndex)
            {
                selectedIndex = 0;
                ControlTemplate = template1;
            }
        }

        public void PreviousContent()
        {
            selectedIndex = selectedIndex - 1;
            int indexCheck = templateIndex;
            if (indexCheck != selectedIndex && (selectedIndex > indexCheck || selectedIndex != -1) || indexCheck == selectedIndex)
            {
                switch (selectedIndex)
                {
                    case 0:
                        ControlTemplate = template1;
                        break;
                    case 1:
                        ControlTemplate = template2;
                        break;
                    case 2:
                        ControlTemplate = template3;
                        break;
                }
            }
            else if (selectedIndex < minIndex)
            {
                selectedIndex = 2;
                ControlTemplate = template3;
            }
        }

        private void NavigatingFirstMenu(object sender, EventArgs e)
        {
            Image imgClick = sender as Image;
            int currentGridRowClicked = (int)imgClick.GetValue(Grid.ColumnProperty);
            Label[] labels = new Label[] { txtItem1, txtItem2, txtItem3, txtItem4, txtItem5 };
            TintedImage[] images = new TintedImage[] { navItem1, navItem2, navItem3, navItem4, navItem5 };
            ControlTemplate[] firstRoleTemps = new ControlTemplate[] { template1, template11, template12, template13, template14 };
            ControlTemplate[] secondRoleTemps = new ControlTemplate[] { template2, template21, template22, template23, template24 };
            ControlTemplate[] thirdRoleTemps = new ControlTemplate[] { template3, template31, template32, template33, template34 };

            foreach (var labelToDefaultColor in labels)
            {
                if (Application.Current.RequestedTheme == OSAppTheme.Light)
                {
                    labelToDefaultColor.TextColor = Color.Black;
                }
                else if (Application.Current.RequestedTheme == OSAppTheme.Dark)
                {
                    labelToDefaultColor.TextColor = Color.White;
                }
            }

            foreach (var imgToDefaultColor in images)
            {
                if (Application.Current.RequestedTheme == OSAppTheme.Light)
                {
                    imgToDefaultColor.TintColor = Color.Black;
                }
                else if (Application.Current.RequestedTheme == OSAppTheme.Dark)
                {
                    imgToDefaultColor.TintColor = Color.White;
                }
            }

            labels[currentGridRowClicked].TextColor = Color.Green;
            images[currentGridRowClicked].TintColor = Color.Green;

            switch (selectedIndex)
            {
                case 0:
                    ControlTemplate = firstRoleTemps[currentGridRowClicked];
                    break;
                case 1:
                    ControlTemplate = secondRoleTemps[currentGridRowClicked];
                    break;
                case 2:
                    ControlTemplate = thirdRoleTemps[currentGridRowClicked];
                    break;
                default:
                    DisplayAlert("", "The chosen page is out of range. Please contact manager.", "Ok");
                    break;
            }
        }

        public void SwitchMenuImagesAndTxt()
        {
            Label[] labels = new Label[] { txtItem2, txtItem3, txtItem4, txtItem5 };
            TintedImage[] tintImgs = new TintedImage[] { navItem2, navItem3, navItem4, navItem5 };

            foreach (var item in labels)
            {
                if (Application.Current.RequestedTheme == OSAppTheme.Light)
                {
                    item.TextColor = Color.Black;
                }
                else if (Application.Current.RequestedTheme == OSAppTheme.Dark)
                {
                    item.TextColor = Color.White;
                }
            }

            foreach (var itemImgs in tintImgs)
            {
                if (Application.Current.RequestedTheme == OSAppTheme.Light)
                {
                    itemImgs.TintColor = Color.Black;
                }
                else if (Application.Current.RequestedTheme == OSAppTheme.Dark)
                {
                    itemImgs.TintColor = Color.White;
                }
            }

            if (ControlTemplate == template1)
            {
                txtItem1.TextColor = Color.Green;
                navItem1.TintColor = Color.Green;
                txtItem1.Text = "Home";
                txtItem2.Text = "Chat";
                txtItem3.Text = "Vehicle";
                txtItem4.Text = "Navi";
                txtItem5.Text = "Delivery";

                if (Application.Current.RequestedTheme == OSAppTheme.Light)
                {
                    navItem2.Source = "chat.png";
                    navItem3.Source = "vehicle.png";
                    navItem4.Source = "compass.png";
                    navItem5.Source = "delivery.png";
                }
                else if (Application.Current.RequestedTheme == OSAppTheme.Dark)
                {
                    navItem2.Source = "chatWhite.png";
                    navItem3.Source = "vehicleWhite.png";
                    navItem4.Source = "compassWhite.png";
                    navItem5.Source = "deliveryWhite.png";
                }
            }
            else if (ControlTemplate == template2)
            {
                txtItem1.TextColor = Color.Green;
                navItem1.TintColor = Color.Green;
                txtItem1.Text = "Home";
                txtItem2.Text = "Chat";
                txtItem3.Text = "NaitonGPS";
                txtItem4.Text = "NaitonGPS";
                txtItem5.Text = "NaitonGPS";

                if (Application.Current.RequestedTheme == OSAppTheme.Light)
                {
                    navItem2.Source = "chat.png";
                    navItem3.Source = "notFound.png";
                    navItem4.Source = "notFound.png";
                    navItem5.Source = "notFound.png";

                }
                else if (Application.Current.RequestedTheme == OSAppTheme.Dark)
                {
                    navItem2.Source = "chatWhite.png";
                    navItem3.Source = "notFoundWhite.png";
                    navItem4.Source = "notFoundWhite.png";
                    navItem5.Source = "notFoundWhite.png";
                }
            }
            else if (ControlTemplate == template3)
            {
                txtItem1.TextColor = Color.Green;
                navItem1.TintColor = Color.Green;
                txtItem1.Text = "Home";
                txtItem2.Text = "Chat";
                txtItem3.Text = "NaitonGPS";
                txtItem4.Text = "NaitonGPS";
                txtItem5.Text = "NaitonGPS";

                if (Application.Current.RequestedTheme == OSAppTheme.Light)
                {
                    navItem2.Source = "chat.png";
                    navItem3.Source = "notFound.png";
                    navItem4.Source = "notFound.png";
                    navItem5.Source = "notFound.png";
                }
                else if (Application.Current.RequestedTheme == OSAppTheme.Dark)
                {
                    navItem2.Source = "chatWhite.png";
                    navItem3.Source = "notFoundWhite.png";
                    navItem4.Source = "notFoundWhite.png";
                    navItem5.Source = "notFoundWhite.png";
                }
            }
        }
    }
}