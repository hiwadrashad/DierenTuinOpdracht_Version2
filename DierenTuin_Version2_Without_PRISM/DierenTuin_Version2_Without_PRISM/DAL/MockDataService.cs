using DierenTuin_Version2_Without_PRISM.Interfaces;
using DierenTuin_Version2_Without_PRISM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
            if (_MockdataService == null)
            {
                _MockdataService = new MockDataService();
                _MockdataService.InitData();
            }
            return _MockdataService;
        }

        public void InitData()
        {
            _apes = new List<ApeModel>()
            {
              new ApeModel
              {
                  id = Guid.NewGuid().ToString(), AmountOfKids = 10, MaleToFemaleRatio = 0.6, AmountOfAdults = 23, AgeOfAnimals = new Dictionary<string, int> { {"Susan",12 }, {"anabel", 10 } }, 
                  AnimalSleepType = Enumeration.EnumAnimalSleepType.Diurnal, AnimalSubSpecies = Enumeration.EnumAnimalSubSpecies.Hominidea, AnimalType = Enumeration.EnumAnimalType.Monkey, FoodType = Enumeration.EnumFoodType.Banana, 
                  SocialType =  Enumeration.EnumSocialType.Social
              }
            };

            _elephants = new List<ElephantModel>()
            {
              new ElephantModel
              {
                  id = Guid.NewGuid().ToString(),AmountOfKids = 3, MaleToFemaleRatio = 0.4, AmountOfAdults = 2, AgeOfAnimals = new Dictionary<string, int>{ { "Lucy", 56}, {"Marelin", 78} },
                  AnimalSleepType = Enumeration.EnumAnimalSleepType.Nocturnal, AnimalSubSpecies = Enumeration.EnumAnimalSubSpecies.Loxodonta, AnimalType = Enumeration.EnumAnimalType.Elephant, FoodType = Enumeration.EnumFoodType.Grass, 
                  SocialType = Enumeration.EnumSocialType.Social
              }

            };

            _lions = new List<LionModel>()
            {
              new LionModel
              {
                  id = Guid.NewGuid().ToString(), AmountOfKids = 2, MaleToFemaleRatio = 0.8, AmountOfAdults = 6, AgeOfAnimals = new Dictionary<string, int>{ { "Sarah", 24}, {"Bob", 12 } },
                  AnimalSleepType = Enumeration.EnumAnimalSleepType.Nocturnal, AnimalSubSpecies = Enumeration.EnumAnimalSubSpecies.Felis, AnimalType = Enumeration.EnumAnimalType.Lion, FoodType = Enumeration.EnumFoodType.Meat,
                  SocialType = Enumeration.EnumSocialType.Social
              }

            };
        }

        public IEnumerable<ApeModel> GetAllApes()
        {
            return _apes;
        }

        public IEnumerable<ElephantModel> GetAllElephants()
        {
            return _elephants;
        }

        public IEnumerable<LionModel> GetAllLions()
        {
            return _lions;
        }

        public ApeModel GetSingleUseApe()
        {
            return _apes.FirstOrDefault();
        }

        public ElephantModel GetSingleUseElephant()
        {
            return _elephants.FirstOrDefault();
        }

        public LionModel GetSingleUseLion()
        {
            return _lions.FirstOrDefault();
        }

        public void UseEnergySingleUseApe()
        {
            _apes.FirstOrDefault().UseEnergy();
        }

        public void UseEnergySingleUseElephant()
        {
            _elephants.FirstOrDefault().UseEnergy();
        }

        public void UseEnergySingleUseLion()
        {
            _lions.FirstOrDefault().UseEnergy();
        }

        public void UseEnergyAllApes()
        {
            foreach (var item in _apes)
            {
                item.UseEnergy();
            }
        }

        public void UseEnergyAllElephants()
        {
            foreach (var item in _elephants)
            {
                item.UseEnergy();
            }
        }

        public void UseEnergyAllLions()
        {
            foreach (var item in _lions)
            {
                item.UseEnergy();
            }
        }

        public void EatSingleUseApes()
        {
            _apes.FirstOrDefault().EatForEnergy();
        }

        public void EatSingleuseElephants()
        {
            _elephants.FirstOrDefault().EatForEnergy();
        }

        public void EatSingleUseLions()
        {
            _lions.FirstOrDefault().EatForEnergy();
        }

        public void EatAllApes()
        { 
          foreach(var item in _apes)
          {
                item.EatForEnergy(); 
          }
        }

        public void EatAllElephants()
        {
            foreach (var item in _elephants)
            {
                item.EatForEnergy();
            }
        }

        public void EatAllLions()
        {
            foreach (var item in _lions)
            {
                item.EatForEnergy();
            }
        }
    }
}
