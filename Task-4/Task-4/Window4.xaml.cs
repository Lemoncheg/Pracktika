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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(ResultBox.Text);
                int result = 1;
                int i = 0;
            lab3:
                if (i < n)
                {
                    goto lab1;
                }
                else
                {
                    goto lab2;
                }
            lab1:
                i++;
                result *= i;
                goto lab3;
            lab2:
                ResultLabel.Content = "" + result;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            Window5 window5 = new Window5();
            window5.Show();
            Close();
        }
    }
}
