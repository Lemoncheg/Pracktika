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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {

        public Window3()
        {
            InitializeComponent();
        }

        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(NValue.Text);
                int result = 0;
                int i = -1;
                do
                {
                    i++;
                    result += i;
                }
                while (i < n);
                MessageBox.Show(result.ToString());
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            Window4 window4 = new Window4();
            window4.Show();
            Close();
        }
    }
}
