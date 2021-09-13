using NaitonGps.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NaitonGps.ViewModels
{
    public class PickListViewModel
    {
        public List<TemplatePickListData> dataForPicklist { get; set; }

        public PickListViewModel()
        {
            dataForPicklist = new List<TemplatePickListData>
            {
                new TemplatePickListData
                {
                    pickListId = 450, picklistAssigneeName = "Jan Hendrik Volders", picklistRackQuantity = 15, picklistRackWeight = 725, picklistColorStatus = "Red"
                },                
                new TemplatePickListData
                {
                    pickListId = 650, picklistAssigneeName = "Arjen Verhaart", picklistRackQuantity = 33, picklistRackWeight = 2500, picklistColorStatus = "Orange"
                },                
                new TemplatePickListData
                {
                    pickListId = 550, picklistAssigneeName = "Jan Hendrik Volders", picklistRackQuantity = 12, picklistRackWeight = 550, picklistColorStatus = "Green"
                },                
                new TemplatePickListData
                {
                    pickListId = 750, picklistAssigneeName = "", picklistRackQuantity = 3, picklistRackWeight = 200, picklistColorStatus = "#00000000"
                },                
                new TemplatePickListData
                {
                    pickListId = 970, picklistAssigneeName = "", picklistRackQuantity = 15, picklistRackWeight = 725, picklistColorStatus = "#00000000"
                },                
                new TemplatePickListData
                {
                    pickListId = 658, picklistAssigneeName = "Ignacio Minaya Sanchez", picklistRackQuantity = 40, picklistRackWeight = 3300, picklistColorStatus = "#00000000"
                },                
                new TemplatePickListData
                {
                    pickListId = 320, picklistAssigneeName = "", picklistRackQuantity = 15, picklistRackWeight = 1250, picklistColorStatus = "#00000000"
                },                
                new TemplatePickListData
                {
                    pickListId = 450, picklistAssigneeName = "Jan Hendrik Volders", picklistRackQuantity = 10, picklistRackWeight = 446, picklistColorStatus = "Green"
                },
            };
        }
    }
}
