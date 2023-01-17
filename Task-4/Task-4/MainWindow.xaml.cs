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

namespace Task_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int value1 = 0;
        private int value2 = 0;
        private bool turn = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                value1 = Convert.ToInt32(Value_1.Text);
                value2 = Convert.ToInt32(Value_2.Text);
                ResultLabel.Content = "";
                if (value1 >= value2)
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    for (int i = value1 + 1; i < value2; i++)
                    {
                        if (turn)
                        {
                            if (i % 2 == 0)
                                continue;
                            else 
                                ResultLabel.Content += $"{i} ";
                        }
                        else
                        {
                            ResultLabel.Content += $"{i} ";
                        }
                    }
                }
                if(ResultLabel.Content == "")
                {
                    MessageBox.Show("Error");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void Turn_Click(object sender, RoutedEventArgs e)
        {
            ResultLabel.Content = "";
            turn = !turn;
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            Close();
        }
    }
}
