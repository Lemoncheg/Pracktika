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

namespace Task_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string word = WordBox.Text;
                switch (word)
                {
                    case "Дождь":
                    case "дождь":
                        WordResult.Content = "Rain";
                        break;
                    case "Погода":
                    case "погода":
                        WordResult.Content = "Weather";
                        break;
                    case "Облачно":
                    case "облачно":
                        WordResult.Content = "Cloudy";
                        break;
                    case "Пасмурно":
                    case "пасмурно":
                        WordResult.Content = "Dull";
                        break;
                    case "Туман":
                    case "туман":
                        WordResult.Content = "Fog";
                        break;
                    case "Снег":
                    case "снег":
                        WordResult.Content = "Snow";
                        break;
                    case "Ураган":
                    case "ураган":
                        WordResult.Content = "Hurricane";
                        break;
                    case "Ветрено":
                    case "ветрено":
                        WordResult.Content = "Windy";
                        break;
                    case "Осадки":
                    case "осадки":
                        WordResult.Content = "Precipitation";
                        break;
                    case "Солнечно":
                    case "солнечно":
                        WordResult.Content = "Sunny";
                        break;
                    default:
                        MessageBox.Show("Такого слова в словаре нету", "Error");
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Некоректно", "Error");
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            Close();
        }
    }
}
