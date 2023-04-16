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
using Dangl.Calculator;

namespace CalculatorWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickToNumber(object sender, RoutedEventArgs e)
        {
            textBlock.Text += ((Button)sender).Content;
        }

        private void ClickToExp(object sender, RoutedEventArgs e)
        {
            var formula = textBlock.Text;
            string formulaSecond = "";
            if (formula != "")
            {
                string res = Calculator.Calculate(formula).Result.ToString();
                formulaSecond += ((Button)sender).Content;
                formulaSecond += res;
                textBlock.Text = Math.Round(Calculator.Calculate(formulaSecond).Result, 5).ToString();
            }
            else if (formula == "")
            {
                textBlock.Text = ((Button)sender).Content.ToString();
            }
        }

        private void ClickToExpThatCanBeRad(object sender, RoutedEventArgs e)
        {
            var formula = textBlock.Text;
            string formulaSecond = "";
            if (formula != "" )
            {
                string res = Calculator.Calculate(formula).Result.ToString();
                if (gradRadio.IsChecked == true)
                {
                    formulaSecond += ((Button)sender).Content;
                    formulaSecond += res;
                    textBlock.Text = Math.Round(Calculator.Calculate(formulaSecond).Result, 5).ToString();
                }
                else if (radRadio.IsChecked == true)
                {
                    res = (Convert.ToDouble(res) * (Math.PI / 180)).ToString();
                    formulaSecond += ((Button)sender).Content;
                    formulaSecond += res;
                    textBlock.Text = Math.Round(Calculator.Calculate(formulaSecond).Result, 5).ToString();
                }
            }
            else if (formula == "")
            {
                MessageBox.Show("введите сначала число");
            }
        }

        private void ClickRouteThree(object sender, RoutedEventArgs e)
        {
            var formula = textBlock.Text;
            string formulaSecond = "";
            string res = Calculator.Calculate(formula).Result.ToString();
            formulaSecond += res;
            formulaSecond += ((Button)sender).Content;
            textBlock.Text = Math.Round(Calculator.Calculate(formulaSecond).Result, 5).ToString(); 
        }

        private void ClickThree(object sender, RoutedEventArgs e)
        {
            var formula = textBlock.Text;
            double res = Convert.ToDouble(Calculator.Calculate(formula).Result.ToString());
            double formulaSecond = Math.Sign(res) * Math.Pow(Math.Abs(res), 1 / 3.0);
            textBlock.Text = formulaSecond.ToString();
        }

        private void ClickToPlusMinus(object sender, RoutedEventArgs e)
        {
            var formula = textBlock.Text;
            double res = Convert.ToDouble(Calculator.Calculate(formula).Result.ToString());
            double formulaSecond = (1) * res;
            textBlock.Text = formulaSecond.ToString();
        }

        private void ClickToNumberRou(object sender, RoutedEventArgs e)
        {
            textBlock.Text += "~";
        }

        private void ClickToInvers(object sender, RoutedEventArgs e)
        {
            var formula = textBlock.Text;
            double res = Convert.ToDouble(Calculator.Calculate(formula).Result.ToString());
            double formulaSecond = 1 / res;
            textBlock.Text = formulaSecond.ToString();
        }

        private void ClickToFactorial(object sender, RoutedEventArgs e)
        {
            try
            {
                var formula = textBlock.Text;
                int res = Convert.ToInt32(Calculator.Calculate(formula).Result.ToString());
                if (res >= 0)
                {
                    long fact = 1;
                    for (int x = 1; x <= res; x++)
                    {
                        fact *= x;
                    }
                    textBlock.Text = fact.ToString();
                }
                else
                {
                    textBlock.Text = "не число";
                }
            }
            catch
            {
                textBlock.Text = "не число";
            }
        }

        private void ClickToNum(object sender, RoutedEventArgs e)
        {
            textBlock.Text += ((Button)sender).Content;
        }

        private void ClickToEquals(object sender, RoutedEventArgs e)
        {
            try
            {
                var formula = textBlock.Text;
                textBlock.Text = Math.Round(Calculator.Calculate(formula).Result , 5).ToString();
            }
            catch
            {
                textBlock.Text = "не число";
            }
        }

        private void EmptyClick(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "";
        }

        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            if (textBlock.Text.Length > 0)
            {
                textBlock.Text = textBlock.Text.Substring(0, textBlock.Text.Length - 1);
            }
        }

        private void ClickToPoint(object sender, RoutedEventArgs e)
        {
            var btn = (Button)sender;
            textBlock.Text += btn.Content.ToString();
        }

        private void ClickToPi(object sender, RoutedEventArgs e)
        {
            var formula = textBlock.Text;
            if (formula != "")
            {
                double res = Convert.ToDouble(Calculator.Calculate(formula).Result.ToString());
                textBlock.Text = Math.Round((res * Math.PI), 5).ToString();
            }
            else
            {
                textBlock.Text = Math.Round((1 * Math.PI * Math.PI), 5).ToString();
            }
        }

        private void ClickToPercent(object sender, RoutedEventArgs e)
        {
            var formula = textBlock.Text;
            if (textBlock.Text != "")
            {
                double res = Convert.ToDouble(Calculator.Calculate(formula).Result.ToString());
                textBlock.Text = Math.Round((res / 100), 5).ToString();
            }
            else
            {
                MessageBox.Show("введите сначала число");
            }
        }
    }
}
