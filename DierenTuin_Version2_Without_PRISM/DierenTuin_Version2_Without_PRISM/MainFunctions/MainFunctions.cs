using DierenTuin_Version2_Without_PRISM.DAL;
using DierenTuin_Version2_Without_PRISM.Interfaces;
using DierenTuin_Version2_Without_PRISM.Models;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
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
                try
                {
                    ListBoxItem item2 = new ListBoxItem();
                    string StoreNameAndEnergy = item.AnimalType.ToString();
                    StoreNameAndEnergy = StoreNameAndEnergy + ": " + item.Energy;
                    item2.Content = StoreNameAndEnergy;
                    return item2;
                }
#pragma warning disable CS0168 // Variable is declared but never used
                catch (AggregateException ex)
#pragma warning restore CS0168 // Variable is declared but never used
                {
                    string original = "Wrong value entered please try again.";
                    using (RijndaelManaged myRijndael = new RijndaelManaged())
                    {
                        myRijndael.GenerateKey();
                        myRijndael.GenerateIV();

                        byte[] encrypted = Security.AESencryption.EncryptStringToBytes(original, myRijndael.Key, myRijndael.IV);

                        string message = Security.AESencryption.DecryptStringFromBytes(encrypted, myRijndael.Key, myRijndael.IV);
                        System.Windows.MessageBox.Show(message);
                    }
                    ListBoxItem item3 = new ListBoxItem();
                    return item3;
                }
#pragma warning disable CS0168 // Variable is declared but never used
                catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
                {
                    System.Windows.MessageBox.Show("Something went wrong.");
                    ListBoxItem item3 = new ListBoxItem();
                    return item3;
                }
            }

            public static ListBoxItem ReturnListBoxItemWithProperStringInput(LionModel item)
            {
                try
                {
                    ListBoxItem item2 = new ListBoxItem();
                    string StoreNameAndEnergy = item.AnimalType.ToString();
                    StoreNameAndEnergy = StoreNameAndEnergy + ": " + item.Energy;
                    item2.Content = StoreNameAndEnergy;
                    return item2;
                }
#pragma warning disable CS0168 // Variable is declared but never used
                catch (AggregateException ex)
#pragma warning restore CS0168 // Variable is declared but never used
                {
                    string original = "Wrong value entered please try again.";
                    using (RijndaelManaged myRijndael = new RijndaelManaged())
                    {
                        myRijndael.GenerateKey();
                        myRijndael.GenerateIV();

                        byte[] encrypted = Security.AESencryption.EncryptStringToBytes(original, myRijndael.Key, myRijndael.IV);

                        string message = Security.AESencryption.DecryptStringFromBytes(encrypted, myRijndael.Key, myRijndael.IV);
                        System.Windows.MessageBox.Show(message);
                    }
                    ListBoxItem item3 = new ListBoxItem();
                    return item3;
                }
#pragma warning disable CS0168 // Variable is declared but never used
                catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
                {
                    System.Windows.MessageBox.Show("Something went wrong.");
                    ListBoxItem item3 = new ListBoxItem();
                    return item3;
                }
            }

            public static ListBoxItem ReturnListBoxItemWithProperStringInput(ElephantModel item)
            {
                try
                {
                    ListBoxItem item2 = new ListBoxItem();
                    string StoreNameAndEnergy = item.AnimalType.ToString();
                    StoreNameAndEnergy = StoreNameAndEnergy + ": " + item.Energy;
                    item2.Content = StoreNameAndEnergy;
                    return item2;
                }
#pragma warning disable CS0168 // Variable is declared but never used
                catch (AggregateException ex)
#pragma warning restore CS0168 // Variable is declared but never used
                {
                    string original = "Wrong value entered please try again.";
                    using (RijndaelManaged myRijndael = new RijndaelManaged())
                    {
                        myRijndael.GenerateKey();
                        myRijndael.GenerateIV();

                        byte[] encrypted = Security.AESencryption.EncryptStringToBytes(original, myRijndael.Key, myRijndael.IV);

                        string message = Security.AESencryption.DecryptStringFromBytes(encrypted, myRijndael.Key, myRijndael.IV);
                        System.Windows.MessageBox.Show(message);
                    }
                    ListBoxItem item3 = new ListBoxItem();
                    return item3;
                }
#pragma warning disable CS0168 // Variable is declared but never used
                catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
                {
                    System.Windows.MessageBox.Show("Something went wrong.");
                    ListBoxItem item3 = new ListBoxItem();
                    return item3;
                }
            }
        }
        
        public  class UseEnergyAllAnimals
        {
       
            public void UseEnergyAllAnimalsPerTick()
            {
                try
                {
                    IDataService _dataService = MockDataService.GetMockDataService();
                    _dataService.UseEnergyAllApes();
                    _dataService.UseEnergyAllElephants();
                    _dataService.UseEnergyAllLions();
                }
#pragma warning disable CS0168 // Variable is declared but never used
                catch (AggregateException ex)
#pragma warning restore CS0168 // Variable is declared but never used
                {
                    string original = "Wrong value entered please try again.";
                    using (RijndaelManaged myRijndael = new RijndaelManaged())
                    {
                        myRijndael.GenerateKey();
                        myRijndael.GenerateIV();

                        byte[] encrypted = Security.AESencryption.EncryptStringToBytes(original, myRijndael.Key, myRijndael.IV);

                        string message = Security.AESencryption.DecryptStringFromBytes(encrypted, myRijndael.Key, myRijndael.IV);
                        System.Windows.MessageBox.Show(message);
                    }
                }
#pragma warning disable CS0168 // Variable is declared but never used
                catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
                {
                    System.Windows.MessageBox.Show("Something went wrong.");
                }

            }
        }
    }
}
