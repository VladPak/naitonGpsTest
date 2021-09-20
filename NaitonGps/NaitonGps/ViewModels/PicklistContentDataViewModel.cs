using NaitonGps.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace NaitonGps.ViewModels
{
    public class PicklistContentDataViewModel : INotifyPropertyChanged
    {
        public ICommand RefreshCommand { protected set; get; }

        public List<PicklistContentData> dataPicklistContentPerItem { get; set; }


        bool _isRefreshing = false;
        public bool IsRefreshing
        {
            get
            {
                return _isRefreshing;
            }

            set
            {
                if (_isRefreshing != value)
                {
                    _isRefreshing = value;
                    OnPropertyChanged("IsRefreshing");

                }
            }

        }

        public PicklistContentDataViewModel()
        {
            dataPicklistContentPerItem = new List<PicklistContentData>
            {
                new PicklistContentData
                {
                    itemId = 1, itemName = "Landing Tread Silver - Blue ice",
                    itemQuantity = 12, itemSubname = "Blue, UP63", itemSizes = "301 cm x 70 cm, 12 mm"
                },
                new PicklistContentData
                {
                    itemId = 1, itemName = "Landing Tread Silver - Green",
                    itemQuantity = 5, itemSubname = "Blue, UP63", itemSizes = "301 cm x 70 cm, 12 mm"
                },
                new PicklistContentData
                {
                    itemId = 1, itemName = "Landing Tread Silver - Blue ice",
                    itemQuantity = 8, itemSubname = "Blue, UP63", itemSizes = "301 cm x 70 cm, 12 mm"
                },
                new PicklistContentData
                {
                    itemId = 1, itemName = "Landing Tread Silver - Blue ice",
                    itemQuantity = 25, itemSubname = "Blue, UP63", itemSizes = "301 cm x 70 cm, 12 mm"
                },
                new PicklistContentData
                {
                    itemId = 1, itemName = "Landing Tread Silver - Blue ice",
                    itemQuantity = 12, itemSubname = "Blue, UP63", itemSizes = "301 cm x 70 cm, 12 mm"
                },
                new PicklistContentData
                {
                    itemId = 1, itemName = "Landing Tread Silver - Blue ice",
                    itemQuantity = 99, itemSubname = "Blue, UP63", itemSizes = "301 cm x 70 cm, 12 mm"
                },                
                new PicklistContentData
                {
                    itemId = 1, itemName = "Landing Tread Silver - Blue ice",
                    itemQuantity = 12, itemSubname = "Blue, UP63", itemSizes = "301 cm x 70 cm, 12 mm"
                },                
                new PicklistContentData
                {
                    itemId = 1, itemName = "Landing Tread Silver - Blue ice",
                    itemQuantity = 12, itemSubname = "Blue, UP63", itemSizes = "301 cm x 70 cm, 12 mm"
                },
            };

            RefreshCommand = new Command<string>((key) =>
            {
                dataPicklistContentPerItem = new List<PicklistContentData>
            {
                new PicklistContentData
                {
                    itemId = 1, itemName = "Landing Tread Silver - Blue ice",
                    itemQuantity = 12, itemSubname = "Blue, UP63", itemSizes = "301 cm x 70 cm, 12 mm"
                },
                new PicklistContentData
                {
                    itemId = 1, itemName = "Landing Tread Silver - Green",
                    itemQuantity = 5, itemSubname = "Blue, UP63", itemSizes = "301 cm x 70 cm, 12 mm"
                },
                new PicklistContentData
                {
                    itemId = 1, itemName = "Landing Tread Silver - Blue ice",
                    itemQuantity = 8, itemSubname = "Blue, UP63", itemSizes = "301 cm x 70 cm, 12 mm"
                },
                new PicklistContentData
                {
                    itemId = 1, itemName = "Landing Tread Silver - Blue ice",
                    itemQuantity = 25, itemSubname = "Blue, UP63", itemSizes = "301 cm x 70 cm, 12 mm"
                },
                new PicklistContentData
                {
                    itemId = 1, itemName = "Landing Tread Silver - Blue ice",
                    itemQuantity = 12, itemSubname = "Blue, UP63", itemSizes = "301 cm x 70 cm, 12 mm"
                },
                new PicklistContentData
                {
                    itemId = 1, itemName = "Landing Tread Silver - Blue ice",
                    itemQuantity = 99, itemSubname = "Blue, UP63", itemSizes = "301 cm x 70 cm, 12 mm"
                },
                new PicklistContentData
                {
                    itemId = 1, itemName = "Landing Tread Silver - Blue ice",
                    itemQuantity = 12, itemSubname = "Blue, UP63", itemSizes = "301 cm x 70 cm, 12 mm"
                },
                new PicklistContentData
                {
                    itemId = 1, itemName = "Landing Tread Silver - Blue ice",
                    itemQuantity = 12, itemSubname = "Blue, UP63", itemSizes = "301 cm x 70 cm, 12 mm"
                },
            };
                IsRefreshing = false;

            });

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
