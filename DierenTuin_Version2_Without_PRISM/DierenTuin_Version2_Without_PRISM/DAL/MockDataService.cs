using DierenTuin_Version2_Without_PRISM.Interfaces;
using DierenTuin_Version2_Without_PRISM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DierenTuin_Version2_Without_PRISM.DAL
{
    public class MockDataService :IDataService
    {
        private List<ApeModel> _apes;
        private List<ElephantModel> _elephants;
        private List<LionModel> _lions;

        private static MockDataService _MockdataService;

        private MockDataService()
        {

        }

        public static MockDataService GetMockDataService()
        { 
        
        }
    }
}
