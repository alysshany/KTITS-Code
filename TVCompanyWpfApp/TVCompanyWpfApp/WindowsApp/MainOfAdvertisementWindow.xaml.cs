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
    /// Логика взаимодействия для MainOfAdvertisementWindow.xaml
    /// </summary>
    public partial class MainOfAdvertisementWindow : Window
    {
        public MainOfAdvertisementWindow()
        {
            InitializeComponent();
            ListOfAdvertisements.ItemsSource = App.Connection.Advertisements.ToList();
        }
        /// <summary>
        /// Special searching text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.LeftCtrl)
            {
                if (Search.Text == "%Голова%коня%")
                {
                    Authorization authorization = new Authorization();
                    authorization.Show();
                    this.Close();
                }
            }
        }
    }
}