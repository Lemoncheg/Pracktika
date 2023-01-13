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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private int valueZoloto = 0;
        private int valueZolotoOnBuy;
        private int valueKristal = 800;
        private int buyKristal = 0;
        private int safeZolota;
        public Window1()
        {
            InitializeComponent();
        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                valueZoloto = StartValue.IsEnabled == true?Convert.ToInt32(StartValue.Text):safeZolota;
                valueZolotoOnBuy = Convert.ToInt32(Value.Text);

                if (valueZoloto < valueZolotoOnBuy)
                {
                    MessageBox.Show($"Недостаточно средств");
                }
                else
                {
                    if (valueZolotoOnBuy < 20)
                    {
                        MessageBox.Show($"Минимум 20 золотых");
                    }
                    else
                    {
                        StartValue.IsEnabled = false;
                        buyKristal = 4 * (valueZolotoOnBuy / 20);
                        valueZoloto -= valueZolotoOnBuy;
                        valueKristal -= buyKristal;
                        MessageBox.Show($"Кол-во кристаллов купленных: {buyKristal}\nЗолота осталось: {valueZoloto}\nКристалов осталось: {valueKristal}", "info");
                        safeZolota = valueZoloto;
                    }
                }
            }
            catch
            {
                MessageBox.Show($"Вы ничего не купили");
                StartValue.IsEnabled = true;
            }
        }
    }
}
