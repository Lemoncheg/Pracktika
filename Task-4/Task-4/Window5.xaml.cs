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

namespace Task_4
{
    /// <summary>
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        private double resZarplata;
        public Window5()
        {
            InitializeComponent();
        }

        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                double zarplata = Convert.ToDouble(Zarplata.Text);
                int year = Convert.ToInt32(Year.Text);
                if (year > 0)
                {
                    if (year < 5)
                    {
                        resZarplata = zarplata + (zarplata * 0.1d);
                    }
                    else if (year >= 5 && year < 10)
                    {
                        resZarplata = zarplata + (zarplata * 0.15d);
                    }
                    else if (year >= 10 && year < 15)
                    {
                        resZarplata = zarplata + (zarplata * 0.25d);
                    }
                    else if (year >= 15 && year < 20)
                    {
                        resZarplata = zarplata + (zarplata * 0.35d);
                    }
                    else if (year >= 20 && year < 25)
                    {
                        resZarplata = zarplata + (zarplata * 0.45d);
                    }
                    else if (year >= 25)
                    {
                        resZarplata = zarplata + (zarplata * 0.50d);
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
                MessageBox.Show(resZarplata.ToString());
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
