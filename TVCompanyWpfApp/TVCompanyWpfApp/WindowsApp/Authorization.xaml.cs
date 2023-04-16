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
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Authorization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AuthorizationButton(object sender, RoutedEventArgs e)
        {
            if (TxtLogin.Text != null && TxtPassword.Password != null)
            {
                var DataLogin = App.Connection.Accounts.Where(z => z.Login == TxtLogin.Text && z.Password == TxtPassword.Password).FirstOrDefault();
                if (DataLogin != null)
                {
                    var User = App.Connection.Users.Where(z => z.Account_Id == DataLogin.Account_Id).FirstOrDefault();
                    CurrentUser.User = User;
                    if (User.Role_Id == 1)
                    {
                        ManagersMainWindow managersMainWindow = new ManagersMainWindow();
                        managersMainWindow.Show();
                        this.Close();
                    }
                    else if (User.Role_Id == 4)
                    {
                        CustomersMainWindow customersMainWindow = new CustomersMainWindow();
                        customersMainWindow.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Authorization is not correct", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter login and password", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}