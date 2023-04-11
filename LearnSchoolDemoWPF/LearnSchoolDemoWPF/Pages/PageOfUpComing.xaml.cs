using LearnSchoolDemoWPF.ADOApp;
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

namespace LearnSchoolDemoWPF.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageOfUpComing.xaml
    /// </summary>
    public partial class PageOfUpComing : Page
    {
        public PageOfUpComing()
        {
            InitializeComponent();
            ListOfClientServices.ItemsSource = App.Connection.ClientService.Where(z => z.StartTime.Day == DateTime.Today.Day || z.StartTime.Day == DateTime.Today.AddDays(1.0).Day).ToList();
        }

        private void BackButton(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PageWithListOfServiceOfAdmin());
        }
    }
}
