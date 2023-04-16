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
    /// Логика взаимодействия для AddingAdvertisementWindow.xaml
    /// </summary>
    public partial class AddingAdvertisementWindow : Window
    {
        List<string> AgeRestrictions = new List<string>();
        List<string> AvailableShowTimes = new List<string>();
        List<string> AvailableShowTimesEnd = new List<string>();

        public AddingAdvertisementWindow()
        {
            InitializeComponent();
            var listOne = App.Connection.AgeRestrictions.ToList();
            var listTwo = App.Connection.DesiredShowTimes.ToList();
            foreach (var item in listOne)
            {
                AgeRestrictions.Add(item.MinAge.ToString());
            }
            foreach (var item in listTwo)
            {
                AvailableShowTimes.Add(item.StartTime.ToString());
                AvailableShowTimesEnd.Add(item.EndTime.ToString());
            }
            ListOfRestriction.ItemsSource = AgeRestrictions;
            ListOfShowTime.ItemsSource = AvailableShowTimes;
            ListOfShowTimeEnd.ItemsSource = AvailableShowTimesEnd;
        }
        /// <summary>
        /// Button to save advertisement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SavingAdvertisement(object sender, RoutedEventArgs e)
        {
            var time = Convert.ToDouble(ListOfShowTime.SelectedItem.ToString());
            var one = Convert.ToInt32(ListOfRestriction.SelectedItem.ToString());
            try
            {
                var showTime = App.Connection.DesiredShowTimes.Where(z => z.StartTime == time).FirstOrDefault();
                var age = App.Connection.AgeRestrictions.Where(z => z.MinAge == one).FirstOrDefault();
                var price = Convert.ToInt32(TxtPrice.Text) + (Convert.ToInt32(TxtPrice.Text) * 7.61 / 100);
                Advertisements advertisements = new Advertisements()
                {
                    Title = TxtTitle.Text,
                    DesiredShowTime_Id = showTime.DesiredShowTime_Id,
                    Duration = Convert.ToDouble(TxtDuration.Text.ToString()),
                    Price = price,
                    AgeRestriction_Id = age.AgeRestriction_Id,
                    User_Id = null,
                    IsPurchased = false
                };
                App.Connection.Advertisements.Add(advertisements);
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