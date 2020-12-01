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
            DataContext = this;
            InitializeComponent();
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem item = new ListBoxItem();
            ApeModel ape = new ApeModel();
            string StoreNameAndEnergy = ape.AnimalType.ToString();
            StoreNameAndEnergy = StoreNameAndEnergy + ": " + ape.Energy;
            item.Content = StoreNameAndEnergy;
            BoxWithInfo.Items.Add(item);
        }

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
    }
}
