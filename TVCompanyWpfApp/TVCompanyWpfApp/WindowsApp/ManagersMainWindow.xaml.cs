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
    /// Логика взаимодействия для ManagersMainWindow.xaml
    /// </summary>
    public partial class ManagersMainWindow : Window
    {
        public ManagersMainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Navigation to Adding window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NavigationToAdvertisement(object sender, RoutedEventArgs e)
        {
            AddingAdvertisementWindow addingAdvertisementWindow = new AddingAdvertisementWindow();
            addingAdvertisementWindow.Show();
            this.Close();
        }
        /// <summary>
        /// Navigation to viewing window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NavigationToViewingWindow(object sender, RoutedEventArgs e)
        {
            ViewingWindow viewingWindow = new ViewingWindow();
            viewingWindow.Show();
            this.Close();
        }
        /// <summary>
        /// Navigation to adding advertisement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NavigationToAddingAdvertisement(object sender, RoutedEventArgs e)
        {
            AddingAdvertisementToEtherWindow addingAdvertisementToEtherWindow = new AddingAdvertisementToEtherWindow();
            addingAdvertisementToEtherWindow.Show();
            this.Close();
        }
    }
}