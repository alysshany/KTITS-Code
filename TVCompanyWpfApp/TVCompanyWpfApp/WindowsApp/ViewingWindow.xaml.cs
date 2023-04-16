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
    /// Логика взаимодействия для ViewingWindow.xaml
    /// </summary>
    public partial class ViewingWindow : Window
    {
        public ViewingWindow()
        {
            InitializeComponent();
            ListOfAdvertisements.ItemsSource = App.Connection.Advertisements.Where(z => z.IsPurchased == false).ToList();
            ListOfPurchasedAdvertisements.ItemsSource = App.Connection.Advertisements.Where(z => z.IsPurchased == true).ToList();
            ListOfBroadcasts.ItemsSource = App.Connection.Broadcasts.ToList();
        }
    }
}