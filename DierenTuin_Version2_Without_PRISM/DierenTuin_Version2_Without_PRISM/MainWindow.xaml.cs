using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DierenTuin_Version2_Without_PRISM.Models;
using DierenTuin_Version2_Without_PRISM.Interfaces;
using DierenTuin_Version2_Without_PRISM.DAL;
using DierenTuin_Version2_Without_PRISM.Timers;
using System.Security.Cryptography;
using DierenTuin_Version2_Without_PRISM.Logging;

namespace DierenTuin_Version2_Without_PRISM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IDataService _dataService = MockDataService.GetMockDataService();

        public MainWindow()
        {
            try
            {
                _dataService = MockDataService.GetMockDataService();
                StaticResources.StaticMainwindow.StaticMainWindowStorage = this;
                DataContext = this;
                InitializeComponent();
                GridMain.Background = Brushes.Aquamarine;
                AnimalChoices.Visibility = Visibility.Visible;
                FeedAllAnimals.Visibility = Visibility.Visible;
                StartProgram.Visibility = Visibility.Visible;
                AddMonkey.Visibility = Visibility.Visible;
                FeedApes.Visibility = Visibility.Visible;
                AddLion.Visibility = Visibility.Visible;
                FeedLion.Visibility = Visibility.Visible;
                AddElephant.Visibility = Visibility.Visible;
                FeedElephant.Visibility = Visibility.Visible;
                Counter1.Visibility = Visibility.Hidden;
                Counter2.Visibility = Visibility.Hidden;
                Counter3.Visibility = Visibility.Hidden;
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

        public async void Logging()
        {
          var item = await Log4NetLogging.logging();
        }

        public void App_Performance_Clicked(object sender, RoutedEventArgs e)
        {
            try
            {
                GridMain.Background = Brushes.CadetBlue;
                AnimalChoices.Visibility = Visibility.Hidden;
                FeedAllAnimals.Visibility = Visibility.Hidden;
                StartProgram.Visibility = Visibility.Hidden;
                AddMonkey.Visibility = Visibility.Hidden;
                FeedApes.Visibility = Visibility.Hidden;
                AddLion.Visibility = Visibility.Hidden;
                FeedLion.Visibility = Visibility.Hidden;
                AddElephant.Visibility = Visibility.Hidden;
                FeedElephant.Visibility = Visibility.Hidden;
                Counter1.Visibility = Visibility.Visible;
                Counter2.Visibility = Visibility.Visible;
                Counter3.Visibility = Visibility.Visible;
                Counter1.Content = "CPU:" + " " + (int)PerformanceCounterClass.PerformanceCounterClass.GetPerformanceCounter().GetFirstPerformanceCounter().NextValue() + " " + "%";
                Counter2.Content = "Available Memory" + " " + (int)PerformanceCounterClass.PerformanceCounterClass.GetPerformanceCounter().GetSecondPerformanceCounter().NextValue() + " " + "MB";
                Counter3.Content = "System Up Time:" + " " + (int)PerformanceCounterClass.PerformanceCounterClass.GetPerformanceCounter().GetSecondPerformanceCounter().NextValue() / 60 / 60 + "Hours";
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

        public void Animal_Header_Clicked(object sender, RoutedEventArgs e)
        {
            try
            {
                AnimalChoices.Visibility = Visibility.Visible;
                GridMain.Background = Brushes.Aquamarine;
                FeedAllAnimals.Visibility = Visibility.Visible;
                StartProgram.Visibility = Visibility.Visible;
                AddMonkey.Visibility = Visibility.Visible;
                FeedApes.Visibility = Visibility.Visible;
                AddLion.Visibility = Visibility.Visible;
                FeedLion.Visibility = Visibility.Visible;
                AddElephant.Visibility = Visibility.Visible;
                FeedElephant.Visibility = Visibility.Visible;
                Counter1.Visibility = Visibility.Hidden;
                Counter2.Visibility = Visibility.Hidden;
                Counter3.Visibility = Visibility.Hidden;
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


        public void EnterAllDataFromDataServiceInListBox()
        {
            try
            {
                BoxWithInfo.Items.Clear();
                foreach (var item in _dataService.GetAllApes())
                {
                    BoxWithInfo.Items.Add(MainFunctions.MainFunctions.ReturnListBoxItems.ReturnListBoxItemWithProperStringInput(item));
                }

                foreach (var item in _dataService.GetAllElephants())
                {
                    BoxWithInfo.Items.Add(MainFunctions.MainFunctions.ReturnListBoxItems.ReturnListBoxItemWithProperStringInput(item));
                }

                foreach (var item in _dataService.GetAllLions())
                {
                    BoxWithInfo.Items.Add(MainFunctions.MainFunctions.ReturnListBoxItems.ReturnListBoxItemWithProperStringInput(item));
                }
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

        private void Quit_Clicked(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Start_Application(object sender, RoutedEventArgs e)
        {
            try
            {
                TimerWithExecutingMethod item = new TimerWithExecutingMethod();
                item.SetInterval();
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

        private void Feed_All_Animals(object sender, RoutedEventArgs e)
        {
            try
            {
                _dataService.EatAllApes();
                _dataService.EatAllElephants();
                _dataService.EatAllLions();
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

        private void Feed_Apes(object sender, RoutedEventArgs e)
        {
            try
            {
                _dataService.EatAllApes();
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

        private void Feed_Lions(object sender, RoutedEventArgs e)
        {
            try
            {
                _dataService.EatAllLions();
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

        private void Feed_Elephants(object sender, RoutedEventArgs e)
        {
            try
            {
                _dataService.EatAllElephants();
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

        private void Add_Apes(object sender, EventArgs e)
        {
            try
            {
                _dataService.AddApe();
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

        private void Add_Lion(object sender, EventArgs e)
        {
            try
            {
                _dataService.AddLion();
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

        private void Add_Elephant(object sender, EventArgs e)
        {
            try
            {
                _dataService.AddElephant();
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
        //private void Test_Click2(object sender, RoutedEventArgs e)
        //{
        //}

        private void Animal_Clicked(object sender, RoutedEventArgs e)
        {
            try
            {

                int index = int.Parse(((Button)e.Source).Uid);

                GridCursor.Margin = new Thickness(200 + (150 * index), 0, 0, 0);

                switch (index)
                {
                    case 0:
                        GridMain.Background = Brushes.Aquamarine;
                        FeedAllAnimals.Visibility = Visibility.Visible;
                        StartProgram.Visibility = Visibility.Visible;
                        AddMonkey.Visibility = Visibility.Visible;
                        FeedApes.Visibility = Visibility.Visible;
                        AddLion.Visibility = Visibility.Visible;
                        FeedLion.Visibility = Visibility.Visible;
                        AddElephant.Visibility = Visibility.Visible;
                        FeedElephant.Visibility = Visibility.Visible;
                        break;
                    case 1:
                        GridMain.Background = Brushes.Aquamarine;
                        FeedAllAnimals.Visibility = Visibility.Hidden;
                        StartProgram.Visibility = Visibility.Visible;
                        AddMonkey.Visibility = Visibility.Visible;
                        FeedApes.Visibility = Visibility.Visible;
                        AddLion.Visibility = Visibility.Hidden;
                        FeedLion.Visibility = Visibility.Hidden;
                        AddElephant.Visibility = Visibility.Hidden;
                        FeedElephant.Visibility = Visibility.Hidden;
                        break;
                    case 2:
                        GridMain.Background = Brushes.Aquamarine;
                        FeedAllAnimals.Visibility = Visibility.Hidden;
                        StartProgram.Visibility = Visibility.Visible;
                        AddMonkey.Visibility = Visibility.Hidden;
                        FeedApes.Visibility = Visibility.Hidden;
                        AddLion.Visibility = Visibility.Visible;
                        FeedLion.Visibility = Visibility.Visible;
                        AddElephant.Visibility = Visibility.Hidden;
                        FeedElephant.Visibility = Visibility.Hidden;
                        break;
                    case 3:
                        GridMain.Background = Brushes.Aquamarine;
                        FeedAllAnimals.Visibility = Visibility.Hidden;
                        StartProgram.Visibility = Visibility.Visible;
                        AddMonkey.Visibility = Visibility.Hidden;
                        FeedApes.Visibility = Visibility.Hidden;
                        AddLion.Visibility = Visibility.Hidden;
                        FeedLion.Visibility = Visibility.Hidden;
                        AddElephant.Visibility = Visibility.Visible;
                        FeedElephant.Visibility = Visibility.Visible;
                        break;
                }
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
