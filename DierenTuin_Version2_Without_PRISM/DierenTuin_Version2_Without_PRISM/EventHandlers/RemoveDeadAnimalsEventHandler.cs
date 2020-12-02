using DierenTuin_Version2_Without_PRISM.DAL;
using DierenTuin_Version2_Without_PRISM.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.RightsManagement;
using System.Text;

namespace DierenTuin_Version2_Without_PRISM.EventHandlers
{
    public class RemoveDeadAnimalsEventHandler
    {
        private IDataService _dataService = MockDataService.GetMockDataService();
        public void RemoveDeadAnimals(object sender, EventArgs e)
        {
            _dataService.RemoveAllStarvedAnimals();
        }
    }
}
