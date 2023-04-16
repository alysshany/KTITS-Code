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

namespace TVCompanyWpfApp.WindowsApp
{
    /// <summary>
    /// Логика взаимодействия для CustomersMainWindow.xaml
    /// </summary>
    public partial class CustomersMainWindow : Window
    {
        public CustomersMainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Button going to advertisement view window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NavigationToAdvertisements(object sender, RoutedEventArgs e)
        {
            AdvertisementBuyingWindow advertisementBuyingWindow = new AdvertisementBuyingWindow();
            advertisementBuyingWindow.Show();
            this.Close();
        }
        /// <summary>
        /// Add money
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddingMoney(object sender, RoutedEventArgs e)
        {
            AddingMoneyWindow addingMoneyWindow = new AddingMoneyWindow();
            addingMoneyWindow.Show();
            this.Close();
        }
    }
}