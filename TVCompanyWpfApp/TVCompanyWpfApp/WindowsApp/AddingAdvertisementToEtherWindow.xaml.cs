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
using System.Windows.Shapes;
using TVCompanyWpfApp.ADOApp;

namespace TVCompanyWpfApp.WindowsApp
{
    /// <summary>
    /// Логика взаимодействия для AddingAdvertisementToEtherWindow.xaml
    /// </summary>
    public partial class AddingAdvertisementToEtherWindow : Window
    {
        List<string> AvailableEthers = new List<string>();
        List<string> Advertisements = new List<string>();

        public AddingAdvertisementToEtherWindow()
        {
            InitializeComponent();
            var listTwo = App.Connection.Advertisements.ToList();
            var listThree = App.Connection.Ethers.ToList();
            foreach (var item in listThree)
            {
                AvailableEthers.Add(item.Title.ToString());
            }
            foreach (var item in listTwo)
            {
                Advertisements.Add(item.Title.ToString());
            }
            ListOfEthers.ItemsSource = AvailableEthers;
            ListOfAdvertisements.ItemsSource = Advertisements;
        }
        /// <summary>
        /// Adding advertisement to ether
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddingAdvertisement(object sender, RoutedEventArgs e)
        {
            var one = ListOfEthers.SelectedItem.ToString();
            var two = ListOfAdvertisements.SelectedItem.ToString();
            try
            {
                var advertisement = App.Connection.Advertisements.Where(z => z.Title== two).FirstOrDefault();
                var ether = App.Connection.Ethers.Where(z => z.Title == one).FirstOrDefault();
                AdvertisementShows advertisementShows = new AdvertisementShows()
                {
                    Advertisement_Id = advertisement.Advertisement_Id,
                    Ether_Id = ether.Ether_Id,
                    StartTime = Convert.ToDouble(TxtStart.Text.ToString()),
                    EndTime = Convert.ToDouble(TxtEnd.Text.ToString())
                };
                App.Connection.AdvertisementShows.Add(advertisementShows);
                App.Connection.SaveChanges();
                MessageBox.Show("Good job");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}