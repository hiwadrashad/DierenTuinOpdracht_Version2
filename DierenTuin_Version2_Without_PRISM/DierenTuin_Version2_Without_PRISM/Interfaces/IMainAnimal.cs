using DierenTuin_Version2_Without_PRISM.Enumeration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DierenTuin_Version2_Without_PRISM.Interfaces
{
    public interface IMainAnimal
    {
        public string id { get; set; }
        public abstract int EnergyUsePerUnit { get; set; }
        private static int EdibleEnergyPerUnit { get; set; }
        public abstract int EdibleAmountPerEnergyPerUnit { get; set; }
        public void UseEnergy();
        public void EatForEnergy();
        public int Energy { get; set; }
        public int AmountOfKids { get; set; }
        public double MaleToFemaleRatio { get; set; }
        public int AmountOfAdults { get; set; }
        public Dictionary<string, int> AgeOfAnimals { get; set; }
        public EnumAnimalSleepType AnimalSleepType { get; set; }
        public EnumAnimalSubSpecies AnimalSubSpecies { get; set; }
        public EnumAnimalType AnimalType { get; set; }
        public EnumFoodType FoodType { get; set; }
        public EnumSocialType SocialType { get; set; }
    }
}
