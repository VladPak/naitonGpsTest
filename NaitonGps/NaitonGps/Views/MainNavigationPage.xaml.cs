using NaitonGps.Models;
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

//Here
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

        public MainNavigationPage()
        {
            InitializeComponent();
            ControlTemplate = template1;
            templateIndex = 0;
            selectedIndex = 0;
            BindingContext = new UserViewModel();

            if (ControlTemplate == template1 || ControlTemplate == template2 || ControlTemplate == template3)
            {
                txtItem1.TextColor = Color.Green;
            }
        }

        //PopUp call
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushPopupAsync(new MorePopUp());
        }

        //Navigation
        //Previous Role
        private void SwipeGestureRecognizer_Swiped_PreviousRole(object sender, SwipedEventArgs e)
        {
            PreviousContent();
            moveMenu();
            NavMenuIconsChange();
        }

        //Next Role
        private void SwipeGestureRecognizer_Swiped_NextRole(object sender, SwipedEventArgs e)
        {
            NextContent();
            moveMenu();
            NavMenuIconsChange();
        }

        //Previous Role
        private void TapGestureRecognizer_Tapped_PreviousRole(object sender, EventArgs e)
        {
            PreviousContent();
            moveMenu();
            NavMenuIconsChange();
        }

        //Next Role
        private void TapGestureRecognizer_Tapped_NextRole(object sender, EventArgs e)
        {
            NextContent();
            moveMenu();
            NavMenuIconsChange();
        }

        public void NextContent()
        {
            //await DisplayAlert("", "Swipe right", "Ok");
            selectedIndex = selectedIndex + 1;
            Label[] labels = new Label[] { txtItem1, txtItem2, txtItem3, txtItem4, txtItem5 };


            int indexCheck = templateIndex;
            if (indexCheck != selectedIndex && selectedIndex < maxIndex + 1)
            {
                switch (selectedIndex)
                {
                    case 0:
                        ControlTemplate = template1;

                        foreach (var item in labels)
                        {
                            if (item.TextColor == Color.Green)
                            {
                                item.TextColor = Color.Black;
                            }
                        }

                        txtItem1.TextColor = Color.Green;
                        break;
                    case 1:
                        ControlTemplate = template2;

                        foreach (var item in labels)
                        {
                            if (item.TextColor == Color.Green)
                            {
                                item.TextColor = Color.Black;
                            }
                        }

                        txtItem1.TextColor = Color.Green;
                        break;
                    case 2:
                        ControlTemplate = template3;

                        foreach (var item in labels)
                        {
                            if (item.TextColor == Color.Green)
                            {
                                item.TextColor = Color.Black;
                            }
                        }

                        txtItem1.TextColor = Color.Green;
                        break;
                }
            }
            else if (selectedIndex > maxIndex)
            {
                selectedIndex = 0;
                ControlTemplate = template1;

                foreach (var item in labels)
                {
                    if (item.TextColor == Color.Green)
                    {
                        item.TextColor = Color.Black;
                    }
                }
                txtItem1.TextColor = Color.Green;
            }
        }

        public void PreviousContent()
        {
            //await DisplayAlert("", "Swipe left", "Ok");
            selectedIndex = selectedIndex - 1;
            Label[] labels = new Label[] { txtItem1, txtItem2, txtItem3, txtItem4, txtItem5 };

            int indexCheck = templateIndex;
            if ((indexCheck != selectedIndex && (selectedIndex > indexCheck || selectedIndex != -1)) || indexCheck == selectedIndex)
            {
                switch (selectedIndex)
                {
                    case 0:
                        ControlTemplate = template1;

                        foreach (var item in labels)
                        {
                            if (item.TextColor == Color.Green)
                            {
                                item.TextColor = Color.Black;
                            }
                        }

                        txtItem1.TextColor = Color.Green;
                        break;
                    case 1:
                        ControlTemplate = template2;

                        foreach (var item in labels)
                        {
                            if (item.TextColor == Color.Green)
                            {
                                item.TextColor = Color.Black;
                            }
                        }

                        txtItem1.TextColor = Color.Green;
                        break;
                    case 2:
                        ControlTemplate = template3;

                        foreach (var item in labels)
                        {
                            if (item.TextColor == Color.Green)
                            {
                                item.TextColor = Color.Black;
                            }
                        }

                        txtItem1.TextColor = Color.Green;
                        break;
                }
            }
            else if (selectedIndex < minIndex)
            {
                selectedIndex = 2;
                ControlTemplate = template3;

                foreach (var item in labels)
                {
                    if (item.TextColor == Color.Green)
                    {
                        item.TextColor = Color.Black;
                    }
                }

                txtItem1.TextColor = Color.Green;
            }
        }

        public async void ChangeMenuCalls(object sender, EventArgs e)
        {
             await DisplayAlert("", "Home is clicked", "Ok");
        }

        async void moveMenu()
        {
            await bottomNavMenu.TranslateTo(0, 200, 200, Easing.Linear);
            await bottomNavMenu.TranslateTo(0, 0);
        }

        //detecting Light/Dark mode for icon change
        OSAppTheme currentTheme = Application.Current.RequestedTheme;

        public void NavMenuIconsChange()
        {
            if (selectedIndex == 0)
            {
                navItem3.Source = "vehicle.png";
                navItem4.Source = "compass.png";
                navItem5.Source = "delivery.png";

                txtItem1.Text = "Home";
                txtItem2.Text = "Chat";
                txtItem3.Text = "Vehicles";
                txtItem4.Text = "Navi";
                txtItem5.Text = "Delivery";
            }
            else if (selectedIndex == 1)
            {
                navItem3.Source = "notFound.png";
                navItem4.Source = "notFound.png";
                navItem5.Source = "notFound.png";

                txtItem1.Text = "Home";
                txtItem2.Text = "Chat";
                txtItem3.Text = "DPage3";
                txtItem4.Text = "DPage4";
                txtItem5.Text = "DPage5";
            }
            else if (selectedIndex == 2)
            {
                navItem3.Source = "notFound.png";
                navItem4.Source = "notFound.png";
                navItem5.Source = "notFound.png";

                txtItem1.Text = "Home";
                txtItem2.Text = "Chat";
                txtItem3.Text = "SPage3";
                txtItem4.Text = "SPage4";
                txtItem5.Text = "SPage5";
            }
        }

        private void NavigatingFirstMenu(object sender, EventArgs e)
        {
            Image imgClick = sender as Image;
            int currentGridRowClicked = (int)imgClick.GetValue(Grid.ColumnProperty);
            Label[] labels = new Label[] { txtItem1, txtItem2, txtItem3, txtItem4, txtItem5 };

            if (selectedIndex == 0 || selectedIndex == 1 || selectedIndex == 2)
            {
                if (currentGridRowClicked == 0 || currentGridRowClicked == 1 || currentGridRowClicked == 2 || currentGridRowClicked == 3 || currentGridRowClicked == 4)
                {
                    foreach (var item in labels)
                    {
                        if (item.TextColor == Color.Green)
                        {
                            item.TextColor = Color.Black;
                        }
                    }
                    labels[currentGridRowClicked].TextColor = Color.Green;
                }
                //switch (currentGridRowClicked)
                //{
                //    case 0:
                //        foreach (var item in labels.Skip(currentGridRowClicked))
                //        {
                //            item.TextColor = Color.Black;
                //        }
                //        labels[currentGridRowClicked].TextColor = Color.Green;
                //        break;
                //    case 1:
                //        labels[currentGridRowClicked].TextColor = Color.Green;
                //        break;
                //    case 2:
                //        labels[currentGridRowClicked].TextColor = Color.Green;
                //        break;
                //    case 3:
                //        labels[currentGridRowClicked].TextColor = Color.Green;
                //        break;
                //    case 4:
                //        labels[currentGridRowClicked].TextColor = Color.Green;
                //        break;
                //    default:
                //        labels[currentGridRowClicked].TextColor = Color.Green;
                //        break;
                //}
                //DisplayAlert("", "Current clicked lbl: " + labels[currentGridRowClicked].ToString(), "Ok");
            }

            if (selectedIndex == 0)
            {
                ControlTemplate = template1;

            }
            else if (selectedIndex == 1)
            {
                ControlTemplate = template2;

            }
            else if (selectedIndex == 2)
            {
                ControlTemplate = template3;

            }
        }

        private void NavigatingSecondMenu(object sender, EventArgs e)
        {
            Image imgClick = sender as Image;
            int currentGridRowClicked = (int)imgClick.GetValue(Grid.ColumnProperty);
            Label[] labels = new Label[] { txtItem1, txtItem2, txtItem3, txtItem4, txtItem5 };

            if (selectedIndex == 0 || selectedIndex == 1 || selectedIndex == 2)
            {
                if (currentGridRowClicked == 0 || currentGridRowClicked == 1 || currentGridRowClicked == 2 || currentGridRowClicked == 3 || currentGridRowClicked == 4)
                {
                    foreach (var item in labels)
                    {
                        if (item.TextColor == Color.Green)
                        {
                            item.TextColor = Color.Black;
                        }
                    }
                    labels[currentGridRowClicked].TextColor = Color.Green;
                }
                //switch (currentGridRowClicked)
                //{
                //    case 0:
                //        foreach (var item in labels.Skip(currentGridRowClicked))
                //        {
                //            item.TextColor = Color.Black;
                //        }
                //        labels[currentGridRowClicked].TextColor = Color.Green;
                //        break;
                //    case 1:
                //        labels[currentGridRowClicked].TextColor = Color.Green;
                //        break;
                //    case 2:
                //        labels[currentGridRowClicked].TextColor = Color.Green;
                //        break;
                //    case 3:
                //        labels[currentGridRowClicked].TextColor = Color.Green;
                //        break;
                //    case 4:
                //        labels[currentGridRowClicked].TextColor = Color.Green;
                //        break;
                //    default:
                //        labels[currentGridRowClicked].TextColor = Color.Green;
                //        break;
                //}
                //DisplayAlert("", "Current clicked lbl: " + labels[currentGridRowClicked].ToString(), "Ok");
            }

            if (selectedIndex == 0)
            {
                ControlTemplate = template11;

            }
            else if (selectedIndex == 1)
            {
                ControlTemplate = template21;

            }
            else if (selectedIndex == 2)
            {
                ControlTemplate = template31;

            }
        }

        private void NavigatingThirdMenu(object sender, EventArgs e)
        {
            Image imgClick = sender as Image;
            int currentGridRowClicked = (int)imgClick.GetValue(Grid.ColumnProperty);
            Label[] labels = new Label[] { txtItem1, txtItem2, txtItem3, txtItem4, txtItem5 };

            if (selectedIndex == 0 || selectedIndex == 1 || selectedIndex == 2)
            {
                if (currentGridRowClicked == 0 || currentGridRowClicked == 1 || currentGridRowClicked == 2 || currentGridRowClicked == 3 || currentGridRowClicked == 4)
                {
                    foreach (var item in labels)
                    {
                        if (item.TextColor == Color.Green)
                        {
                            item.TextColor = Color.Black;
                        }
                    }
                    labels[currentGridRowClicked].TextColor = Color.Green;
                }
                //switch (currentGridRowClicked)
                //{
                //    case 0:
                //        foreach (var item in labels.Skip(currentGridRowClicked))
                //        {
                //            item.TextColor = Color.Black;
                //        }
                //        labels[currentGridRowClicked].TextColor = Color.Green;
                //        break;
                //    case 1:
                //        labels[currentGridRowClicked].TextColor = Color.Green;
                //        break;
                //    case 2:
                //        labels[currentGridRowClicked].TextColor = Color.Green;
                //        break;
                //    case 3:
                //        labels[currentGridRowClicked].TextColor = Color.Green;
                //        break;
                //    case 4:
                //        labels[currentGridRowClicked].TextColor = Color.Green;
                //        break;
                //    default:
                //        labels[currentGridRowClicked].TextColor = Color.Green;
                //        break;
                //}
                //DisplayAlert("", "Current clicked lbl: " + labels[currentGridRowClicked].ToString(), "Ok");
            }

            if (selectedIndex == 0)
            {
                ControlTemplate = template12;

            }
            else if (selectedIndex == 1)
            {
                ControlTemplate = template22;

            }
            else if (selectedIndex == 2)
            {
                ControlTemplate = template32;

            }
        }

        private void NavigatingFourthMenu(object sender, EventArgs e)
        {
            Image imgClick = sender as Image;
            int currentGridRowClicked = (int)imgClick.GetValue(Grid.ColumnProperty);
            Label[] labels = new Label[] { txtItem1, txtItem2, txtItem3, txtItem4, txtItem5 };

            if (selectedIndex == 0 || selectedIndex == 1 || selectedIndex == 2)
            {
                if (currentGridRowClicked == 0 || currentGridRowClicked == 1 || currentGridRowClicked == 2 || currentGridRowClicked == 3 || currentGridRowClicked == 4)
                {
                    foreach (var item in labels)
                    {
                        if (item.TextColor == Color.Green)
                        {
                            item.TextColor = Color.Black;
                        }
                    }
                    labels[currentGridRowClicked].TextColor = Color.Green;
                }
                //switch (currentGridRowClicked)
                //{
                //    case 0:
                //        foreach (var item in labels.Skip(currentGridRowClicked))
                //        {
                //            item.TextColor = Color.Black;
                //        }
                //        labels[currentGridRowClicked].TextColor = Color.Green;
                //        break;
                //    case 1:
                //        labels[currentGridRowClicked].TextColor = Color.Green;
                //        break;
                //    case 2:
                //        labels[currentGridRowClicked].TextColor = Color.Green;
                //        break;
                //    case 3:
                //        labels[currentGridRowClicked].TextColor = Color.Green;
                //        break;
                //    case 4:
                //        labels[currentGridRowClicked].TextColor = Color.Green;
                //        break;
                //    default:
                //        labels[currentGridRowClicked].TextColor = Color.Green;
                //        break;
                //}
                //DisplayAlert("", "Current clicked lbl: " + labels[currentGridRowClicked].ToString(), "Ok");
            }

            if (selectedIndex == 0)
            {
                ControlTemplate = template13;

            }
            else if (selectedIndex == 1)
            {
                ControlTemplate = template23;

            }
            else if (selectedIndex == 2)
            {
                ControlTemplate = template33;

            }
        }

        private void NavigatingFifthMenu(object sender, EventArgs e)
        {
            Image imgClick = sender as Image;
            int currentGridRowClicked = (int)imgClick.GetValue(Grid.ColumnProperty);
            Label[] labels = new Label[] { txtItem1, txtItem2, txtItem3, txtItem4, txtItem5 };

            if (selectedIndex == 0 || selectedIndex == 1 || selectedIndex == 2)
            {
                if (currentGridRowClicked == 0 || currentGridRowClicked == 1 || currentGridRowClicked == 2 || currentGridRowClicked == 3 || currentGridRowClicked == 4)
                {
                    //foreach (var item in labels.Skip(currentGridRowClicked))
                    //{
                    //    if (item.TextColor == Color.Green)
                    //    {
                    //        item.TextColor = Color.Black;
                    //    }
                    //}

                    foreach (var item in labels)
                    {
                        if (item.TextColor == Color.Green)
                        {
                            item.TextColor = Color.Black;
                        }
                    }
                    labels[currentGridRowClicked].TextColor = Color.Green;
                }
                //switch (currentGridRowClicked)
                //{
                //    case 0:
                //        foreach (var item in labels.Skip(currentGridRowClicked))
                //        {
                //            item.TextColor = Color.Black;
                //        }
                //        labels[currentGridRowClicked].TextColor = Color.Green;
                //        break;
                //    case 1:
                //        labels[currentGridRowClicked].TextColor = Color.Green;
                //        break;
                //    case 2:
                //        labels[currentGridRowClicked].TextColor = Color.Green;
                //        break;
                //    case 3:
                //        labels[currentGridRowClicked].TextColor = Color.Green;
                //        break;
                //    case 4:
                //        labels[currentGridRowClicked].TextColor = Color.Green;
                //        break;
                //    default:
                //        labels[currentGridRowClicked].TextColor = Color.Green;
                //        break;
                //}
                //DisplayAlert("", "Current clicked lbl: " + labels[currentGridRowClicked].ToString(), "Ok");
            }

            if (selectedIndex == 0)
            {
                ControlTemplate = template14;

            }
            else if (selectedIndex == 1)
            {
                ControlTemplate = template24;

            }
            else if (selectedIndex == 2)
            {
                ControlTemplate = template34;

            }
        }


        public void HighLightEffect(object sender, EventArgs e)
        {
            Image imgClick = sender as Image;
            int currentGridRowClicked = (int)imgClick.GetValue(Grid.ColumnProperty);

            Label[] labels = new Label[] { txtItem1, txtItem2, txtItem3, txtItem4, txtItem5 };

            if (selectedIndex == 0)
            {
                switch (currentGridRowClicked)
                {
                    case 0:
                        labels[currentGridRowClicked].TextColor = Color.Green;
                        break;                    
                    case 1:
                        labels[currentGridRowClicked].TextColor = Color.Green;
                        break;                    
                    case 2:
                        labels[currentGridRowClicked].TextColor = Color.Green;
                        break;                    
                    case 3:
                        labels[currentGridRowClicked].TextColor = Color.Green;
                        break;                    
                    case 4:
                        labels[currentGridRowClicked].TextColor = Color.Green;
                        break;  
                    default:
                        labels[currentGridRowClicked].TextColor = Color.Green;
                        break;
                }
            }
            else if (selectedIndex == 1)
            {

            }
            else if (selectedIndex == 2)
            {

            }
            
            if (ControlTemplate == template1 || ControlTemplate == template2 || ControlTemplate == template3)
            {
                txtItem1.TextColor = Color.Green;
                txtItem2.TextColor = Color.Black;
                txtItem3.TextColor = Color.Black;
                txtItem4.TextColor = Color.Black;
                txtItem5.TextColor = Color.Black;
            }
            else if (ControlTemplate == template11 || ControlTemplate == template21 || ControlTemplate == template31)
            {
                txtItem1.TextColor = Color.Black;
                txtItem2.TextColor = Color.Green;
                txtItem3.TextColor = Color.Black;
                txtItem4.TextColor = Color.Black;
                txtItem5.TextColor = Color.Black;
            }
            else if (ControlTemplate == template12 || ControlTemplate == template22 || ControlTemplate == template32)
            {
                txtItem1.TextColor = Color.Black;
                txtItem2.TextColor = Color.Black;
                txtItem3.TextColor = Color.Green;
                txtItem4.TextColor = Color.Black;
                txtItem5.TextColor = Color.Black;
            }              
            else if (ControlTemplate == template13 || ControlTemplate == template23 || ControlTemplate == template33)
            {
                txtItem1.TextColor = Color.Black;
                txtItem2.TextColor = Color.Black;
                txtItem3.TextColor = Color.Black;
                txtItem4.TextColor = Color.Green;
                txtItem5.TextColor = Color.Black;
            }              
            else if (ControlTemplate == template14 || ControlTemplate == template24 || ControlTemplate == template34)
            {
                txtItem1.TextColor = Color.Black;
                txtItem2.TextColor = Color.Black;
                txtItem3.TextColor = Color.Black;
                txtItem4.TextColor = Color.Black;
                txtItem5.TextColor = Color.Green;
            }
            else
            {
                txtItem1.TextColor = Color.Green;
                txtItem2.TextColor = Color.Green;
                txtItem3.TextColor = Color.Green;
                txtItem4.TextColor = Color.Green;
                txtItem5.TextColor = Color.Green;
            }

        }
    }
}