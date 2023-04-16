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
using TVCompanyWpfApp.ClassApp;

namespace TVCompanyWpfApp.WindowsApp
{
    /// <summary>
    /// Логика взаимодействия для AddingMoneyWindow.xaml
    /// </summary>
    public partial class AddingMoneyWindow : Window
    {
        public AddingMoneyWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Adding money to balance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddingMoney(object sender, RoutedEventArgs e)
        {
            CurrentUser.User.Balances.Balance += Convert.ToDouble(TxtNumber.Text);
            App.Connection.SaveChanges();
            MessageBox.Show("Success");
        }
    }
}