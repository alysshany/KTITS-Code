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

namespace IntersectionPointApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double a;
        public double b;
        public double c;
        public double d;
        public double e;
        public double f;

        public string firstLine;
        public string secondLine;

        public string answerLine;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, RoutedEventArgs ev)
        {
            if (double.TryParse(aText.Text, out a) && double.TryParse(bText.Text, out b) &&
                double.TryParse(cText.Text, out c) && double.TryParse(dText.Text, out d) &&
                double.TryParse(eText.Text, out e) && double.TryParse(fText.Text, out f))
            {

                if (a != 0 && b != 0)
                {
                    firstLine = "Первая прямая - прямая общего положения";
                }
                else if (a == 0 && b == 0)
                {
                    firstLine = "Первая прямая - множество точек плоскости";
                }
                else if (a != 0 && b == 0 && c != 0)
                {
                    firstLine = "Первая прямая - прямая, параллельная OY";
                }
                else if (a != 0 && b == 0 && c == 0)
                {
                    firstLine = "Первая прямая - ось OX";
                }
                else if (a == 0 && b != 0 && c != 0)
                {
                    firstLine = "Первая прямая - прямая, параллельная OX";
                }
                else if (a == 0 && b != 0 && c == 0)
                {
                    firstLine = "Первая прямая - ось OY";
                }

                //second line

                if (d != 0 && e != 0)
                {
                    secondLine = "Вторая прямая - прямая общего положения";
                }
                else if (d == 0 && e == 0)
                {
                    secondLine = "Вторая прямая - множество точек плоскости";
                }
                else if (d != 0 && e == 0 && f != 0)
                {
                    secondLine = "Вторая прямая - прямая, параллельная OY";
                }
                else if (d != 0 && e == 0 && f == 0)
                {
                    secondLine = "Вторая прямая - ось OX";
                }
                else if (d == 0 && e != 0 && f != 0)
                {
                    secondLine = "Вторая прямая - прямая, параллельная OX";
                }
                else if (d == 0 && e != 0 && d == 0)
                {
                    secondLine = "Вторая прямая - ось OY";
                }

                double mainDelta = DeltaSearching(a, b, d, e);
                double xDelta = DeltaSearching(c, b, f, e);
                double yDelta = DeltaSearching(a, c, d, f);

                if (mainDelta != 0)
                {
                    answerLine = "Единственное решение";
                }
                else
                {
                    if (xDelta != 0 || yDelta != 0)
                    {
                        answerLine = "Решений нет";
                    }
                    else
                    {
                        answerLine = "Множество решений";
                    }
                }

                Printing();

            }
            else
            {
                MessageBox.Show($"Введите числа!");
            }
        }

        public double DeltaSearching(double a, double b, double c, double d)
        {
            return (a * d - b * c);
        }

        public void Printing()
        {
            MessageBox.Show($"{firstLine}. {secondLine}. {answerLine}.");
        }
    }
}
