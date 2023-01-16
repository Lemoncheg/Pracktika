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
    
    public partial class Window1 : Window
    {
       
        public Window1()
        {
            InitializeComponent();
        }
        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double value1 = Convert.ToDouble(Value_1.Text);
                double value2 = Convert.ToDouble(Value_2.Text);
                char znak = Convert.ToChar(Znak.Text);

                switch (znak)
                {
                    case '+':
                        ResultLabel.Content = "" + Math.Round(value1 + value2, 4);
                        break;
                    case '-':
                        ResultLabel.Content = "" + Math.Round(value1 - value2, 4);
                        break;
                    case '/':
                        if (value1 == 0 || value2 == 0)
                        {
                            MessageBox.Show("Деление на ноль", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else
                            ResultLabel.Content = "" + Math.Round(value1 / value2, 4);
                        break;
                    case '*':
                            ResultLabel.Content = "" + Math.Round(value1 * value2, 4);
                        break;
                    default:
                        ResultLabel.Content = "";
                        MessageBox.Show("Неккоректно");
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Неккоректный ввод данных", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                ResultLabel.Content = "";
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
            Close();
        }
    }
    
}
