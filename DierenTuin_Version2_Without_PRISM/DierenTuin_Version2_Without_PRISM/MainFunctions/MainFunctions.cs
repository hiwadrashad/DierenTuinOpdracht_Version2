using DierenTuin_Version2_Without_PRISM.DAL;
using DierenTuin_Version2_Without_PRISM.Interfaces;
using DierenTuin_Version2_Without_PRISM.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace DierenTuin_Version2_Without_PRISM.MainFunctions
{
    public class MainFunctions
    {

        public static class ReturnListBoxItems
        {
            public static ListBoxItem ReturnListBoxItemWithProperStringInput(ApeModel item)
            {
                ListBoxItem item2 = new ListBoxItem();
                string StoreNameAndEnergy = item.AnimalType.ToString();
                StoreNameAndEnergy = StoreNameAndEnergy + ": " + item.Energy;
                item2.Content = StoreNameAndEnergy;
                return item2;
            }

            public static ListBoxItem ReturnListBoxItemWithProperStringInput(LionModel item)
            {
                ListBoxItem item2 = new ListBoxItem();
                string StoreNameAndEnergy = item.AnimalType.ToString();
                StoreNameAndEnergy = StoreNameAndEnergy + ": " + item.Energy;
                item2.Content = StoreNameAndEnergy;
                return item2;
            }

            public static ListBoxItem ReturnListBoxItemWithProperStringInput(ElephantModel item)
            {
                ListBoxItem item2 = new ListBoxItem();
                string StoreNameAndEnergy = item.AnimalType.ToString();
                StoreNameAndEnergy = StoreNameAndEnergy + ": " + item.Energy;
                item2.Content = StoreNameAndEnergy;
                return item2;
            }
        }
        
        public  class UseEnergyAllAnimals
        {
            public void UseEnergyAllAnimalsPerTick()
            {
                IDataService _dataService = MockDataService.GetMockDataService();
                _dataService.UseEnergyAllApes();
                _dataService.UseEnergyAllElephants();
                _dataService.UseEnergyAllLions();
 
            }
        }
    }
}
