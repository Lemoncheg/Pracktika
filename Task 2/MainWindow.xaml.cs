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

namespace Task_2
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Task1Button_Click(object sender, RoutedEventArgs e)
        {
            // task 1
            int i = 0;
            string j = "Hello/ word";
            float b = 2.5f;
            double c = 2.6666d;
            char g = '~';
            bool can = true;
            byte d = 1;
            long h = 222222222;
            short u = 4546;
            decimal m = 233;
        }
        // task 2
        private void Task2Button_Click(object sender, RoutedEventArgs e)
        {
            int a = 10;
            int b = 38 * 17;
            int c = (31 - 5 * a) / b;//0
            MessageBox.Show("" + c);
        }

        private void Task3Button_Click(object sender, RoutedEventArgs e)
        {
            int photosCount = 52;
            int countPerColumn = 3;

            int fullRowsCount = photosCount / countPerColumn;
            int overflowCount = photosCount % countPerColumn;

            MessageBox.Show("Заполнится рядов - " + fullRowsCount + "\nНе влезит фотографий - " + overflowCount);
        }

        private void Task4Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }
        private void Task5Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
        }

        private void Task6Button_Click(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.Show();
        }
    }
}
