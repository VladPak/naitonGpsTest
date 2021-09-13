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
                    pickListId = 450, picklistAssigneeName = "Jan Hendrik Volders", picklistRackQuantity = 15, picklistRackWeight = 725
                },                
                new TemplatePickListData
                {
                    pickListId = 450, picklistAssigneeName = "Arjen Verhaart", picklistRackQuantity = 33, picklistRackWeight = 2500
                },                
                new TemplatePickListData
                {
                    pickListId = 450, picklistAssigneeName = "Jan Hendrik Volders", picklistRackQuantity = 12, picklistRackWeight = 550
                },                
                new TemplatePickListData
                {
                    pickListId = 450, picklistAssigneeName = "", picklistRackQuantity = 3, picklistRackWeight = 200
                },                
                new TemplatePickListData
                {
                    pickListId = 450, picklistAssigneeName = "", picklistRackQuantity = 15, picklistRackWeight = 725
                },                
                new TemplatePickListData
                {
                    pickListId = 450, picklistAssigneeName = "Ignacio Minaya Sanchez", picklistRackQuantity = 40, picklistRackWeight = 3300
                },                
                new TemplatePickListData
                {
                    pickListId = 450, picklistAssigneeName = "", picklistRackQuantity = 15, picklistRackWeight = 1250
                },                
                new TemplatePickListData
                {
                    pickListId = 450, picklistAssigneeName = "Jan Hendrik Volders", picklistRackQuantity = 10, picklistRackWeight = 446
                },
            };
        }
    }
}
