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
            _dataService = MockDataService.GetMockDataService();
            StaticResources.StaticMainwindow.StaticMainWindowStorage = this;
            DataContext = this;
            InitializeComponent();
        }

        public void EnterAllDataFromDataServiceInListBox()
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

        private void Start_Application(object sender, RoutedEventArgs e)
        {
            TimerWithExecutingMethod item = new TimerWithExecutingMethod();
            item.SetInterval();

        }

        private void Feed_All_Animals(object sender, RoutedEventArgs e)
        {
            _dataService.EatAllApes();
            _dataService.EatAllElephants();
            _dataService.EatAllLions();

        }

        private void Feed_Apes(object sender, RoutedEventArgs e)
        {
            _dataService.EatAllApes();
        }

        private void Feed_Lions(object sender, RoutedEventArgs e)
        {
            _dataService.EatAllLions();
        }

        private void Feed_Elephants(object sender, RoutedEventArgs e)
        {
            _dataService.EatAllElephants();
        }

        private void Add_Apes(object sender, EventArgs e)
        {
            _dataService.AddApe();
        }

        private void Add_Lion(object sender, EventArgs e)
        {
            _dataService.AddLion();
        }

        private void Add_Elephant(object sender, EventArgs e)
        {
            _dataService.AddElephant();
        }
        //private void Test_Click2(object sender, RoutedEventArgs e)
        //{
        //}

        private void Animal_Clicked(object sender, RoutedEventArgs e)
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

        private void AddMonkey_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
