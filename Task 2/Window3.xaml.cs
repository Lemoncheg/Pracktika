﻿using System;
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
        private string result;
        public Window3()
        {
            InitializeComponent();
        }

        private void AnswerButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(BoxAnswer.Text == "")
                {
                    QuestionsLabel.Content = "Ответь на вопрос";
                    QuestionsLabel.Foreground = Brushes.Red;
                    i--;
                }
                else
                    i++;
                switch (i)
                {
                    case 1:
                        QuestionsLabel.Foreground = Brushes.GreenYellow;
                        result += $"Ваше имя: {BoxAnswer.Text}";
                        QuestionsLabel.Content = "Сколько вам лет?";
                        break;
                    case 2:
                        QuestionsLabel.Foreground = Brushes.GreenYellow;
                        result += $"\nВаш возрост: {Convert.ToInt32(BoxAnswer.Text)}";
                        QuestionsLabel.Content = "Ваш знак зодиака?";
                        break;
                    case 3:
                        QuestionsLabel.Foreground = Brushes.GreenYellow;
                        result += $"\nПо знаку задиака вы: {BoxAnswer.Text}";
                        QuestionsLabel.Content = "Кем вы работатете?";
                        break;
                    case 4:
                        QuestionsLabel.Foreground = Brushes.GreenYellow;
                        result += $"\nВы роботаете: {(BoxAnswer.Text)}";
                        MessageBox.Show(result, "Info", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                        i = 0;
                        result = "";
                        break;
                    default:
                        QuestionsLabel.Foreground = Brushes.GreenYellow;
                        QuestionsLabel.Content = "Как вас зовут?";
                        break;
                }
            }

            catch
            {
                QuestionsLabel.Foreground = Brushes.Red;
                QuestionsLabel.Content = "Ответь на вопрос";
                if(i == 2)
                {
                    i--;
                }
            }
        }
    }
}