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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        private int i = 0;
        private int cont;
        private string result;
        public Window3()
        {
            InitializeComponent();
        }

        private void AnswerButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (BoxAnswer.Text == "")
                {
                    MessageBox.Show("Ответь на вопрос", "Error");
                }
                else
                {
                    i++;
                }
                switch (i)
                {
                    case 1:
                        if(BoxAnswer.Text != "")
                        {
                            result += $"Ваше имя: {BoxAnswer.Text}";
                            BoxAnswer.Text = "";
                            QuestionsLabel.Content = "Сколько вам лет?";
                            cont = i;
                        }
                        break;
                    case 2:
                        if (BoxAnswer.Text != "")
                        {
                            if (Convert.ToInt32(BoxAnswer.Text) < 0)
                            {
                                MessageBox.Show("Ответь на вопрос", "Error");
                                i = 2;
                            }
                            else
                            {
                                result += $"\nВаш возрост: {Convert.ToInt32(BoxAnswer.Text)}";
                                BoxAnswer.Text = "";
                                QuestionsLabel.Content = "Ваш знак зодиака?";
                                cont = i;
                            }
                        }
                        break;
                    case 3:
                        if (BoxAnswer.Text != "")
                        {
                            result += $"\nПо знаку задиака вы: {BoxAnswer.Text}";
                            BoxAnswer.Text = "";
                            QuestionsLabel.Content = "Кем вы работатете?";
                            cont = i;
                        }
                        break;
                    case 4:
                        if (BoxAnswer.Text != "")
                        {
                            result += $"\nВы роботаете: {BoxAnswer.Text}";
                            BoxAnswer.Text = "";
                            MessageBox.Show(result, "Info", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                            i = 0;
                            result = "";
                            cont = i;
                        }
                        break;
                    default:
                        if (BoxAnswer.Text != "")
                        {
                            QuestionsLabel.Foreground = Brushes.GreenYellow;
                            QuestionsLabel.Content = "Как вас зовут?";
                            cont = i;
                        }
                        break;
                }
            }

            catch
            {
                MessageBox.Show("Ответь на вопрос", "Error");
                i = cont;
            }
        }
    }
}
