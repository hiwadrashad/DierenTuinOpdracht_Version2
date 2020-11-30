using DierenTuin_Version2_Without_PRISM.Enumeration;
using DierenTuin_Version2_Without_PRISM.ModelStructures;
using DierenTuin_Version2_Without_PRISM.Structs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DierenTuin_Version2_Without_PRISM.Models
{
    public sealed class LionModel : MainAnimalStructure<string>
    {
        #region
        [Key]

        public new string id { get; set; }

        [Display(Name = "Energy")]

        private int _Energy = 100;

        [Display(Name = "Amount of kids")]

        private int _AmountOfKids;

        [Display(Name = "Male to female ratio")]

        private double _MaleToFemaleRatio;

        [Display(Name = "Amount of adults")]

        private int _AmounOfAdults;

        [Display(Name = "Energy use per unit")]

        private int _EnergyUsePerUnit;

        [Display(Name = "Edible energy per unit")]

        private int _EdibleEnergyPerUnit;

        [Display(Name = "Edible amount per energy per unit")]

        private int _EdibleAmountPerEnergyPerUnit;

        [Display(Name = "Name of animals")]

        private IEnumerable<string> _NamesOfAnimals;

        [Display(Name = "Age of animals")]

        private Dictionary<string, int> _AgeOfAnimals;

        [Display(Name = "Sleep type of animal")]

        private EnumAnimalSleepType _AnimalSleepType;

        [Display(Name = "Animal sub-species")]

        private EnumAnimalSubSpecies _AnimalSubSpecies;

        [Display(Name = "Type of animal")]

        private EnumAnimalType _AnimalType;

        [Display(Name = "Food type of animal")]

        private EnumFoodType _FoodType;

        [Display(Name = "Sociability of animal")]

        private EnumSocialType _SocialType;

        private void AssignEnergy(int value)
        {
            EnergyStruct energy = new EnergyStruct(value);
            _Energy = energy.Energy;
            OnPropertyChanged();

        }

        public override int Energy
        {
            get =>
                _Energy;

            set =>
             AssignEnergy(value);

        }
        private void AssignAMountOfKids(int value)
        {
            AmountOfKidsStruct amountOfKids = new AmountOfKidsStruct(value);
            _AmountOfKids = amountOfKids.AmountOfKids;
            OnPropertyChanged();

        }

        [Display(Name = "Amount of kids")]

        public override int AmountOfKids
        {
            get =>
                _AmountOfKids;
            set =>
                AssignAMountOfKids(value);
        }

        private void AssignMaleToFemaleRatio(double value)
        {

            _MaleToFemaleRatio = value;
            OnPropertyChanged();
        }

        [Display(Name = "Male to female ratio")]

        public override double MaleToFemaleRatio
        {
            get =>
                _MaleToFemaleRatio;
            set =>
                AssignMaleToFemaleRatio(value);
        }

        private void AssignAmountOfAdults(int value)
        {
            AmountOfAdultsStruct amountOfAdults = new AmountOfAdultsStruct(value);
            _AmounOfAdults = amountOfAdults.AmountOfAdults;
            OnPropertyChanged();
        }

        [Display(Name = "Amount of adults")]

        public override int AmountOfAdults

        {
            get =>
                _AmounOfAdults;
            set =>
                AssignAmountOfAdults(value);
        }

        private void AssignEnergyUsePerUnit(int value)
        {
            _EnergyUsePerUnit = value;
            OnPropertyChanged();
        }

        [Display(Name = "Energy use per unit")]

        public override int EnergyUsePerUnit
        {
            get =>
                _EnergyUsePerUnit;
            set =>
                AssignEnergyUsePerUnit(10);
        }

        private void AssignEdibleEnergyPerUnit(int value)
        {
            _EdibleEnergyPerUnit = value;
            OnPropertyChanged();
        }

        [Display(Name = "Edible energy per unit")]

        public override int EdibleEnergyPerUnit
        {
            get =>
                _EdibleEnergyPerUnit;
            set =>
                AssignEdibleEnergyPerUnit(25);
        }

        private void AssignEdibleAmountPerenergyPerUnit(int value)
        {
            _EdibleAmountPerEnergyPerUnit = value;
            OnPropertyChanged();
        }

        [Display(Name = "Edible amount per energy per unit")]

        public override int EdibleAmountPerEnergyPerUnit
        {
            get =>
                _EdibleAmountPerEnergyPerUnit;
            set =>
                AssignEdibleAmountPerenergyPerUnit(25);
        }

        public override void UseEnergy()
        {
            Energy -= EnergyUsePerUnit;
        }

        public override void EatForEnergy()
        {
            Energy += EdibleEnergyPerUnit * EdibleAmountPerEnergyPerUnit;
        }

        private void AssignNamesOfAnimals(IEnumerable<string> value)
        {
            _NamesOfAnimals = value;
            OnPropertyChanged();
        }

        [Display(Name = "Names of animals")]

        public override IEnumerable<string> NamesOfAnimals
        {
            get =>
                _NamesOfAnimals;
            set =>
                AssignNamesOfAnimals(value);
        }

        private void AssignAgeOfanimals(Dictionary<string, int> value)
        {
            _AgeOfAnimals = value;
            OnPropertyChanged();
        }

        [Display(Name = "Age of animals")]

        public override Dictionary<string, int> AgeOfAnimals
        {
            get =>
                _AgeOfAnimals;
            set =>
                AssignAgeOfanimals(value);
        }

        private void AssignAnimalSleepType(EnumAnimalSleepType value)
        {
            _AnimalSleepType = value;
            OnPropertyChanged();
        }

        [Display(Name = "Animal sleep type")]

        public override EnumAnimalSleepType AnimalSleepType
        {
            get =>
                _AnimalSleepType;
            set =>
                AssignAnimalSleepType(value);
        }

        private void AssignAnimalSubSpecies(EnumAnimalSubSpecies value)
        {
            _AnimalSubSpecies = value;
            OnPropertyChanged();
        }

        [Display(Name = "Animal sub-species")]

        public override EnumAnimalSubSpecies AnimalSubSpecies
        {
            get =>
                _AnimalSubSpecies;
            set =>
                AssignAnimalSubSpecies(value);
        }

        private void AssignAnimalType(EnumAnimalType value)
        {
            _AnimalType = value;
            OnPropertyChanged();
        }

        [Display(Name = "Animal type")]

        public override EnumAnimalType AnimalType
        {
            get =>
                    _AnimalType;
            set =>
                AssignAnimalType(value);
        }

        private void AssignFoodType(EnumFoodType value)
        {
            _FoodType = value;
            OnPropertyChanged();
        }

        [Display(Name = "Food type eaten")]

        public override EnumFoodType FoodType
        {
            get =>
                _FoodType;
            set =>
                AssignFoodType(value);
        }

        private void AssignSocialType(EnumSocialType value)
        {
            _SocialType = value;
            OnPropertyChanged();
        }

        [Display(Name = "Social type animal")]

        public override EnumSocialType SocialType
        {
            get =>
                 _SocialType;
            set =>
                AssignSocialType(value);
        }

        #endregion
        public LionModel()
        {
            MainAnimalStructure<string>.InheritedOrNot = true;
            id = Guid.NewGuid().ToString();
        }

    }
}
