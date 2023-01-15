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

namespace Task_2
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
                int valueInOchered = Convert.ToInt32(ValueInOchered.Text);
                int timeInHour = (valueInOchered * 10) / 60;
                int timeInMinute = (valueInOchered * 10) - (timeInHour * 60);
                TimeLabel.Content = $"Время: {timeInHour} часа {timeInMinute} минут";
            }
            catch
            {
                MessageBox.Show("Введите количество бабушек", "Ошибка");
            }
        }
    }
}
