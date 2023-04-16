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
using TVCompanyWpfApp.ClassApp;

namespace TVCompanyWpfApp.WindowsApp
{
    /// <summary>
    /// Логика взаимодействия для AdvertisementBuyingWindow.xaml
    /// </summary>
    public partial class AdvertisementBuyingWindow : Window
    {
        public AdvertisementBuyingWindow()
        {
            InitializeComponent();
            ListOfAgeRestrictions.ItemsSource = App.Connection.AgeRestrictions.ToList();
        }
        /// <summary>
        /// Age Restriction change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangingListOfAgeRestrictions(object sender, SelectionChangedEventArgs e)
        {
            var age = (AgeRestrictions)ListOfAgeRestrictions.SelectedItem;
            ListOfAdvertisements.ItemsSource = App.Connection.Advertisements.Where(z => z.AgeRestriction_Id == age.AgeRestriction_Id && z.IsPurchased == false).ToList();
        }
        /// <summary>
        /// When user thy to buy advertisement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuyingAdvertisement(object sender, SelectionChangedEventArgs e)
        {
            var advertisement = (Advertisements)ListOfAdvertisements.SelectedItem;
            if (advertisement.Price <= CurrentUser.User.Balances.Balance)
            {
                CurrentUser.User.Balances.Balance -= advertisement.Price;
                advertisement.User_Id = CurrentUser.User.User_Id;
                advertisement.IsPurchased = true;
                App.Connection.SaveChanges();
                ListOfAdvertisements.Items.Refresh();
                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show("Sorry, you cannot purchase it", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}