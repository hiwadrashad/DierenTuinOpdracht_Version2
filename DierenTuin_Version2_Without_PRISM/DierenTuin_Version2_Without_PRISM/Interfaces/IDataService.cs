using DierenTuin_Version2_Without_PRISM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DierenTuin_Version2_Without_PRISM.Interfaces
{
    interface IDataService
    {
        IEnumerable<ApeModel> GetAllApes();
        IEnumerable<ElephantModel> GetAllElephants();
        IEnumerable<LionModel> GetAllLions();
        ApeModel GetSingleUseApe();
        ElephantModel GetSingleUseElephant();
        LionModel GetSingleUseLion();
        void UseEnergySingleUseApe();
        void UseEnergySingleUseElephant();
        void UseEnergySingleUseLion();
        void UseEnergyAllApes();
        void UseEnergyAllElephants();
        void UseEnergyAllLions();
        void EatSingleUseApes();
        void EatSingleuseElephants();
        void EatSingleUseLions();
        void EatAllApes();
        void EatAllElephants();
        void EatAllLions();
        void AddApe();
        void AddLion();
        void AddElephant();
        public void RemoveAllStarvedAnimals();
    }
}
