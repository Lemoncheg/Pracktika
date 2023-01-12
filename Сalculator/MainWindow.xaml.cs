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
                switch (Combo_Function.SelectedIndex)
                {
                    case 0:
                        ResultLabel.Content = "" + (value1 + value2);
                        break;
                    case 1:
                        ResultLabel.Content = "" + (value1 - value2);
                        break;
                    case 2:
                        if(value1 == 0)
                        {
                            MessageBox.Show("Деление на ноль", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        ResultLabel.Content = "" + (value1 / value2);
                        break;
                    case 3:
                        ResultLabel.Content = "" + (value1 * value2);
                        break;
                    case 4:
                        ResultLabel.Content = "" + Math.Round((Math.Sin(value2)));
                        break;
                    case 5:
                        ResultLabel.Content = "" + Math.Round((Math.Cos(value2)));
                        break;
                    case 6:
                        ResultLabel.Content = "" + Math.Round((Math.Sin(value2) / Math.Cos(value2)));
                        break;
                    case 7:
                        ResultLabel.Content = "" + Math.Round((Math.Cos(value2) / Math.Sin(value2)));
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            Value_1.Visibility = Visibility.Visible;
            ValueText.Visibility = Visibility.Visible;
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            Value_1.Visibility = Visibility.Visible;
            ValueText.Visibility = Visibility.Visible;
        }

        private void DelenieButton_Click(object sender, RoutedEventArgs e)
        {
            Value_1.Visibility = Visibility.Visible;
            ValueText.Visibility = Visibility.Visible;
        }

        private void UmnojenieButton_Click(object sender, RoutedEventArgs e)
        {
            Value_1.Visibility = Visibility.Visible;
            ValueText.Visibility = Visibility.Visible;
        }
        private void SinButton_Click(object sender, RoutedEventArgs e)
        {
            Value_1.Visibility = Visibility.Hidden;
            ValueText.Visibility = Visibility.Hidden;
        }

        private void CosButton_Click(object sender, RoutedEventArgs e)
        {
            Value_1.Visibility = Visibility.Hidden;
            ValueText.Visibility = Visibility.Hidden;
        }

        private void TngButton_Click(object sender, RoutedEventArgs e)
        {
            Value_1.Visibility = Visibility.Hidden;
            ValueText.Visibility = Visibility.Hidden;
        }

        private void CtngButton_Click(object sender, RoutedEventArgs e)
        {
            Value_1.Visibility = Visibility.Hidden;
            ValueText.Visibility = Visibility.Hidden;
        }
    }
}
