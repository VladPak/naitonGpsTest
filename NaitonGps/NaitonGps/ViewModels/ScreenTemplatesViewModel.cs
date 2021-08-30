using NaitonGps.Models;
using NaitonGps.Views;
using NaitonGps.ViewsForEachRole;
using NaitonGps.ViewsForEachRole.Driver;
using NaitonGps.ViewsForEachRole.SalesExecutive;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace NaitonGps.ViewModels
{
    public class ScreenTemplatesViewModel
    {
        public List<Screens> screens { get; set; }


        public ScreenTemplatesViewModel()
        {
            //var tapGestureRecognizer = new TapGestureRecognizer();
            ////tapGestureRecognizer.NumberOfTapsRequired = 1;
            ////tapGestureRecognizer.Tapped += (s, e) => {
            ////    ControlTemplate = 
            ////};

            screens = new List<Screens>
            {
                new Screens
                {
                    screenNumber = 1, ScreenTitle = "AccountingReportsDiagnosticReports", ScreenImage = "home.png", ScreenLink = new ControlTemplate(typeof(FirstRoleTemplate))
                },
                new Screens
                {
                    screenNumber = 2, ScreenTitle = "AccountingReportsDiagnosticReports3", ScreenImage = "chat.png", ScreenLink = new ControlTemplate(typeof(ManagerSecondPage))
                },
                new Screens
                {
                    screenNumber = 3, ScreenTitle = "BalanceSheetForm", ScreenImage = "delivery.png", ScreenLink = new ControlTemplate(typeof(ManagerThirdPage))
                },
                new Screens
                {
                    screenNumber = 4, ScreenTitle = "DublicateContentForm", ScreenImage = "compass.png", ScreenLink = new ControlTemplate(typeof(ManagerFourthPage))
                },
                new Screens
                {
                    screenNumber = 5, ScreenTitle = "InternalTransport", ScreenImage = "vehicle.png", ScreenLink = new ControlTemplate(typeof(ManagerFifthPage))
                },
                new Screens
                {
                    screenNumber = 6, ScreenTitle = "InvalidEmailAddressesForm", ScreenImage = "chat.png", ScreenLink = new ControlTemplate(typeof(SecondRoleTemplate))
                },
                new Screens
                {
                    screenNumber = 7, ScreenTitle = "NaitonTranslation", ScreenImage = "chat.png", ScreenLink = new ControlTemplate(typeof(DriverSecondPage))
                },
                new Screens
                {
                    screenNumber = 8, ScreenTitle = "NewMainDelivery", ScreenImage = "chat.png", ScreenLink = new ControlTemplate(typeof(DriverThirdPage))
                },
                new Screens
                {
                    screenNumber = 9, ScreenTitle = "OrderLogForm", ScreenImage = "chat.png", ScreenLink = new ControlTemplate(typeof(DriverFourthPage))
                },
                new Screens
                {
                    screenNumber = 10, ScreenTitle = "PerformanceScreenForm", ScreenImage = "chat.png", ScreenLink = new ControlTemplate(typeof(DriverFifthPage))
                },
                new Screens
                {
                    screenNumber = 11, ScreenTitle = "ReeleezeeForm", ScreenImage = "delivery.png", ScreenLink = new ControlTemplate(typeof(ThirdRoleTemplate))
                },
                new Screens
                {
                    screenNumber = 12, ScreenTitle = "RentalOverviewForm", ScreenImage = "delivery.png", ScreenLink = new ControlTemplate(typeof(SalesExSecondPage))
                },
                new Screens
                {
                    screenNumber = 13, ScreenTitle = "ReportMenuNum1", ScreenImage = "delivery.png", ScreenLink = new ControlTemplate(typeof(SalesExThirdPage))
                },
                new Screens
                {
                    screenNumber = 14, ScreenTitle = "ReportMenuNum2", ScreenImage = "delivery.png", ScreenLink = new ControlTemplate(typeof(SalesExFourthPage))
                },
                new Screens
                {
                    screenNumber = 15, ScreenTitle = "ReportMenuNum3", ScreenImage = "delivery.png", ScreenLink = new ControlTemplate(typeof(SalesExFifthPage))
                },
                new Screens
                {
                    screenNumber = 16, ScreenTitle = "ReportMenuNum4", ScreenImage = "compass.png", ScreenLink = new ControlTemplate(typeof(FourthRoleTemplate))
                },
                new Screens
                {
                    screenNumber = 17, ScreenTitle = "ReportMenuNum5", ScreenImage = "compass.png", ScreenLink = new ControlTemplate(typeof(FourthRoleTemplate2))
                },
                new Screens
                {
                    screenNumber = 18, ScreenTitle = "ReportMenuNum6", ScreenImage = "compass.png", ScreenLink = new ControlTemplate(typeof(FourthRoleTemplateThree))
                },
                new Screens
                {
                    screenNumber = 19, ScreenTitle = "ReportMenuNum7", ScreenImage = "compass.png", ScreenLink = new ControlTemplate(typeof(FourthRoleTemplateFour))
                },
                new Screens
                {
                    screenNumber = 20, ScreenTitle = "ReportMenuNum8", ScreenImage = "compass.png", ScreenLink = new ControlTemplate(typeof(FourthRoleTemplateFive))
                },
                new Screens
                {
                    screenNumber = 21, ScreenTitle = "ReportMenuNum9", ScreenImage = "settings.png", ScreenLink = new ControlTemplate(typeof(FifthRoleTemplate))
                },
                new Screens
                {
                    screenNumber = 22, ScreenTitle = "Test", ScreenImage = "notification.png", ScreenLink = new ControlTemplate(typeof(DefaultTemplate))
                },                
                new Screens
                {
                    screenNumber = 23, ScreenTitle = "Test2", ScreenImage = "notification.png", ScreenLink = new ControlTemplate(typeof(DefaultTemplate))
                },
            };
        }
    }
}
