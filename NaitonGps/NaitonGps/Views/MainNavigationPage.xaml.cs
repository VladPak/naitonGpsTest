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
            HighLightEffect();
            templateIndex = 0;
            selectedIndex = 0;
            BindingContext = new UserViewModel();
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
            bodyContentAnimated();
            NavMenuIconsChange();
            HighLightEffect();

        }

        //Next Role
        private void SwipeGestureRecognizer_Swiped_NextRole(object sender, SwipedEventArgs e)
        {
            NextContent();
            moveMenu();
            bodyContentAnimated();
            NavMenuIconsChange();
            HighLightEffect();

        }

        //Previous Role
        private void TapGestureRecognizer_Tapped_PreviousRole(object sender, EventArgs e)
        {
            bodyContentAnimated();
            PreviousContent();
            moveMenu();
            NavMenuIconsChange();
            HighLightEffect();

        }

        //Next Role
        private void TapGestureRecognizer_Tapped_NextRole(object sender, EventArgs e)
        {
            bodyContentAnimated();
            NextContent();
            moveMenu();
            NavMenuIconsChange();
            HighLightEffect();
        }

        public void NextContent()
        {
            //await DisplayAlert("", "Swipe right", "Ok");
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
            //await DisplayAlert("", "Swipe left", "Ok");
            selectedIndex = selectedIndex - 1;

            int indexCheck = templateIndex;
            if ((indexCheck != selectedIndex && (selectedIndex > indexCheck || selectedIndex != -1)) || indexCheck == selectedIndex)
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

        public async void ChangeMenuCalls(object sender, EventArgs e)
        {
             await DisplayAlert("", "Home is clicked", "Ok");
        }

        async void moveMenu()
        {
            await bottomNavMenu.TranslateTo(0, 200, 200, Easing.Linear);
            await bottomNavMenu.TranslateTo(0, 0);
        }

        public void bodyContentAnimated()
        {
            //await template1.FadeTo(0, 0, Easing.Linear);
            //await UserList.TranslateTo(0, -300, 100, Easing.Linear);
            //await UserList.FadeTo(1, 252, Easing.Linear);
            //await UserList.TranslateTo(0, 0, 250);
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
            if (selectedIndex == 0)
            {
                ControlTemplate = template1;
                HighLightEffect();

            }
            else if (selectedIndex == 1)
            {
                ControlTemplate = template2;
                HighLightEffect();

            }
            else if (selectedIndex == 2)
            {
                ControlTemplate = template3;
                HighLightEffect();

            }
        }

        private void NavigatingSecondMenu(object sender, EventArgs e)
        {
            if (selectedIndex == 0)
            {
                ControlTemplate = template11;
                HighLightEffect();

            }
            else if (selectedIndex == 1)
            {
                ControlTemplate = template21;
                HighLightEffect();

            }
            else if (selectedIndex == 2)
            {
                ControlTemplate = template31;
                HighLightEffect();

            }
        }

        private void NavigatingThirdMenu(object sender, EventArgs e)
        {
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


        public void HighLightEffect()
        {
            //Label[] labels = new Label[] { txtItem1, txtItem2, txtItem3, txtItem4, txtItem5 };

            if (ControlTemplate == template1 || ControlTemplate == template2 || ControlTemplate == template3)
            {
                txtItem1.TextColor = Color.Black;
                txtItem2.TextColor = Color.Black;
                txtItem3.TextColor = Color.Black;
                txtItem4.TextColor = Color.Black;
                txtItem5.TextColor = Color.Black;
            }
            //else if (ControlTemplate == template11 || ControlTemplate == template21 || ControlTemplate == template31)
            //{
            //    txtItem1.TextColor = Color.Black;
            //    txtItem2.TextColor = Color.Red;
            //    txtItem3.TextColor = Color.Black;
            //    txtItem4.TextColor = Color.Black;
            //    txtItem5.TextColor = Color.Black;
            //}               
            else if (ControlTemplate == template12 || ControlTemplate == template22 || ControlTemplate == template32)
            {
                txtItem1.TextColor = Color.Black;
                txtItem2.TextColor = Color.Black;
                txtItem3.TextColor = Color.Red;
                txtItem4.TextColor = Color.Black;
                txtItem5.TextColor = Color.Black;
            }              
            else if (ControlTemplate == template13 || ControlTemplate == template23 || ControlTemplate == template33)
            {
                txtItem1.TextColor = Color.Black;
                txtItem2.TextColor = Color.Black;
                txtItem3.TextColor = Color.Black;
                txtItem4.TextColor = Color.Red;
                txtItem5.TextColor = Color.Black;
            }              
            else if (ControlTemplate == template14 || ControlTemplate == template24 || ControlTemplate == template34)
            {
                txtItem1.TextColor = Color.Black;
                txtItem2.TextColor = Color.Black;
                txtItem3.TextColor = Color.Black;
                txtItem4.TextColor = Color.Black;
                txtItem5.TextColor = Color.Red;
            }            

        }
    }
}