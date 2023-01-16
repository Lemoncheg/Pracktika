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

namespace Task_3
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(ValueDiapozon.Text) >= 0)
                {
                    if (Convert.ToInt32(ValueDiapozon.Text) < 14)
                    {
                        Diapozon.Content = "промежуток [0 - 14]";
                    }
                    if (Convert.ToInt32(ValueDiapozon.Text) > 14 && Convert.ToInt32(ValueDiapozon.Text) < 35)
                    {
                        Diapozon.Content = "промежуток [15 - 35]";
                    }
                    if (Convert.ToInt32(ValueDiapozon.Text) > 35 && Convert.ToInt32(ValueDiapozon.Text) <= 50)
                    {
                        Diapozon.Content = "промежуток [36 - 50]";
                    }
                    if (Convert.ToInt32(ValueDiapozon.Text) >= 50 && Convert.ToInt32(ValueDiapozon.Text) <= 100)
                    {
                        Diapozon.Content = "промежуток [50 - 100]";
                    }
                }
                else
                {
                    MessageBox.Show("Вне диапозона");
                    Diapozon.Content = "";
                }
            }
            catch
            {
                MessageBox.Show("Некорекно");
                Diapozon.Content = "";
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.Show();
            Close();
        }
    }
}
