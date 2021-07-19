using NaitonGps.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Essentials;

namespace NaitonGps.ViewModels
{
    public class UserViewModel
    {
        public ObservableCollection<Users> users { get; set; }
        public ObservableCollection<Orders> orders { get; set; }
        public ObservableCollection<Roles> roles { get; set; }

        public UserViewModel()
        {
            users = new ObservableCollection<Users>
            {
                new Users
                {
                    userEmail = Preferences.Get("loginEmail", string.Empty), userRole = "Admin"
                },
            };


            roles = new ObservableCollection<Roles>
            {
                new Roles
                {
                    RoleTitle = "Manager"
                },
                new Roles
                {
                    RoleTitle = "Driver"
                },
                new Roles
                {
                    RoleTitle = "Sales exec"
                }
            };

            orders = new ObservableCollection<Orders>
            {
                new Orders
                {
                    orderTitle = "Order #1021", orderStatus = "Waiting", orderDate ="06/07/2021"
                },
                new Orders
                {
                    orderTitle = "Order #2021", orderStatus = "Pending", orderDate ="06/12/2021"
                },
                new Orders
                {
                    orderTitle = "Order #3021", orderStatus = "Waiting", orderDate ="06/09/2021"
                },
                new Orders
                {
                    orderTitle = "Order #4021", orderStatus = "Pending", orderDate ="06/12/2021"
                },
                new Orders
                {
                    orderTitle = "Order #5021", orderStatus = "Pending", orderDate ="06/13/2021"
                },
                new Orders
                {
                    orderTitle = "Order #6021", orderStatus = "Canceled", orderDate ="04/05/2021"
                },
                new Orders
                {
                    orderTitle = "Order #7021", orderStatus = "Delivered", orderDate ="03/10/2021"
                },
            };
        }
    }
}
