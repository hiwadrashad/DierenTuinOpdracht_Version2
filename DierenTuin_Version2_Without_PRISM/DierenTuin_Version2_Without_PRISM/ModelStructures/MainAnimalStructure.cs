using DierenTuin_Version2_Without_PRISM.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using DierenTuin_Version2_Without_PRISM.Enumeration;
using DierenTuin_Version2_Without_PRISM.Structs;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace DierenTuin_Version2_Without_PRISM.ModelStructures
{

   
    public abstract class MainAnimalStructure<T> : INotifyPropertyChanged, IMainAnimal
    {
        #region
        [Key]
        public string id { get; set; }

        [Display(Name = "Energy")]

        private int _Energy;

        [Display(Name = "Amount of kids")]

        private int _AmountOfKids;

        [Display(Name = "Male to female ratio")]

        private double _MaleToFemaleRatio;

        [Display(Name = "Amount of adults")]

        private int _AmountofAdults;

        public static bool InheritedOrNot { get; set; }

        public abstract int EnergyUsePerUnit { get; set; }

        public abstract int EdibleEnergyPerUnit { get; set; }

        public abstract int EdibleAmountPerEnergyPerUnit { get; set; }

        public virtual void UseEnergy() => Energy -= EnergyUsePerUnit;

        public virtual void EatForEnergy() => Energy += EdibleEnergyPerUnit * EdibleAmountPerEnergyPerUnit;

        public virtual int Energy 
        {
            get 
            { 
                return _Energy; 
            }
            set 
            {
                EnergyStruct energy = new EnergyStruct(value);
                _Energy = energy.Energy;
                OnPropertyChanged();
            }
        }

       [Display(Name = "Amount of kids")]

        public virtual int AmountOfKids
        {
            get
            {
                return _AmountOfKids;
            }
            set
            {
                AmountOfKidsStruct amountOfKids = new AmountOfKidsStruct(value);
                _AmountOfKids = amountOfKids.AmountOfKids;
                OnPropertyChanged();
            }
        }

        [Display(Name = "Male to female ratio")]

        public virtual double MaleToFemaleRatio
        {
            get
            {
                return _MaleToFemaleRatio;
            }
            set
            {
                _MaleToFemaleRatio = value;
                OnPropertyChanged();
            }
        }


        [Display(Name = "Amount of adults")]

        public virtual int AmountOfAdults
        {
            get
            {
                return _AmountofAdults;
            }
            set
            {
                AmountOfAdultsStruct amountOfAdults = new AmountOfAdultsStruct(value); 
                _AmountofAdults = amountOfAdults.AmountOfAdults;
                OnPropertyChanged();
            }
        }

        [Display(Name = "Name of animals")]
        public virtual IEnumerable<T> NamesOfAnimals { get; set; }

        [Display(Name = "Age of animals")]

        public virtual Dictionary<string, int> AgeOfAnimals { get; set; }

        [Display(Name = "Sleep type of animal")]

        public virtual EnumAnimalSleepType AnimalSleepType  {get;set;}

        [Display(Name = "Animal sub-species")]

        public virtual EnumAnimalSubSpecies AnimalSubSpecies { get; set; }

        [Display(Name = "Type of animal")]

        public abstract EnumAnimalType AnimalType { get; set; }

        [Display(Name = "Food type of animal")]

        public virtual EnumFoodType FoodType { get; set; }

        [Display(Name = "Sociability of animal")]

        public virtual EnumSocialType SocialType { get; set; }
        
        public virtual event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        public MainAnimalStructure()
        {
            id = Guid.NewGuid().ToString();
        }
    }
}
