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

namespace Сalculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double value1 = 0;
        private double value2 = 0;
        private double result;
        private double degres;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                value1 = Value_1.Text != "" ? Convert.ToDouble(Value_1.Text): 0;
                value2 = Convert.ToDouble(Value_2.Text);

                if (ComboDegReg.SelectedIndex == 0)
                {
                    degres = Math.PI / 180;
                }
                else
                    degres = 1;

                switch (Combo_Function.SelectedIndex)
                {
                    case 0:
                        Math.Round(value1 + value2, 4);
                        break;
                    case 1:
                        result = Math.Round(value1 - value2,4);
                        break;
                    case 2:
                        if(value1 == 0)
                        {
                            MessageBox.Show("Деление на ноль", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        result = Math.Round(value1 / value2, 4);
                        break;
                    case 3:
                        result = Math.Round(value1 * value2, 4);
                        break;
                    case 4:
<<<<<<< HEAD
                        result = Math.Round(Math.Sin(value2 * degres) , 4);
=======
                        ResultLabel.Content = "" + Math.Round(Math.Sin(value2), 4);
>>>>>>> d84f6903a79d0db762dd57471cc6066d84d02c8f
                        break;
                    case 5:
                        result = Math.Round(Math.Cos(value2 * degres), 4);
                        break;
                    case 6:
                        result = Math.Round(Math.Sin(value2 * degres) / Math.Cos(value2 * degres), 4);
                        break;
                    case 7:
                        result = Math.Round(Math.Cos(value2 * degres) / Math.Sin(value2 * degres), 4);
                        break;
                }
                ResultLabel.Content = "" + result;
            }
            catch
            {
                MessageBox.Show("Неккоректный ввод данных", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            Value_1.Visibility = Visibility.Visible;
            ValueText.Visibility = Visibility.Visible;
            ComboDegReg.Visibility = Visibility.Hidden;
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            Value_1.Visibility = Visibility.Visible;
            ValueText.Visibility = Visibility.Visible;
            ComboDegReg.Visibility = Visibility.Hidden;
        }

        private void DelenieButton_Click(object sender, RoutedEventArgs e)
        {
            Value_1.Visibility = Visibility.Visible;
            ValueText.Visibility = Visibility.Visible;
            ComboDegReg.Visibility = Visibility.Hidden;
        }

        private void UmnojenieButton_Click(object sender, RoutedEventArgs e)
        {
            Value_1.Visibility = Visibility.Visible;
            ValueText.Visibility = Visibility.Visible;
            ComboDegReg.Visibility = Visibility.Hidden;
        }
        private void SinButton_Click(object sender, RoutedEventArgs e)
        {
            Value_1.Visibility = Visibility.Hidden;
            ValueText.Visibility = Visibility.Hidden;
            ComboDegReg.Visibility = Visibility.Visible;
        }

        private void CosButton_Click(object sender, RoutedEventArgs e)
        {
            Value_1.Visibility = Visibility.Hidden;
            ValueText.Visibility = Visibility.Hidden;
            ComboDegReg.Visibility = Visibility.Visible;
        }

        private void TngButton_Click(object sender, RoutedEventArgs e)
        {
            Value_1.Visibility = Visibility.Hidden;
            ValueText.Visibility = Visibility.Hidden;
            ComboDegReg.Visibility = Visibility.Visible;
        }

        private void CtngButton_Click(object sender, RoutedEventArgs e)
        {
            Value_1.Visibility = Visibility.Hidden;
            ValueText.Visibility = Visibility.Hidden;
            ComboDegReg.Visibility = Visibility.Visible;
        }
    }
}
