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

namespace Calculator
{
    public partial class MainWindow : Window
    {
        private string exercise = "";
        private int answer = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Action_Calculator()
        {

        }

        private void Button_Click_Plus(object sender, RoutedEventArgs e)
        {
            view_answer_label.Content += "+";
        }

        private void Button_Click_Minus(object sender, RoutedEventArgs e)
        {
            view_answer_label.Content += "-";
        }

        private void Button_Click_Multiplication(object sender, RoutedEventArgs e)
        {
            view_answer_label.Content += "*";
        }

        private void Button_Click_Percent(object sender, RoutedEventArgs e)
        {
            view_answer_label.Content += "%";
        }

        private void Button_Click_Seven(object sender, RoutedEventArgs e)
        {
            view_answer_label.Content += "7";
        }

        private void Button_Click_Eight(object sender, RoutedEventArgs e)
        {
            view_answer_label.Content += "8";
        }

        private void Button_Click_Nine(object sender, RoutedEventArgs e)
        {
            view_answer_label.Content += "9";
        }

        private void Button_Click_Four(object sender, RoutedEventArgs e)
        {
            view_answer_label.Content += "4";
        }

        private void Button_Click_Five(object sender, RoutedEventArgs e)
        {
            view_answer_label.Content += "5";
        }

        private void Button_Click_Six(object sender, RoutedEventArgs e)
        {
            view_answer_label.Content += "6";
        }

        private void Button_Click_One(object sender, RoutedEventArgs e)
        {
            view_answer_label.Content += "1";
        }

        private void Button_Click_Two(object sender, RoutedEventArgs e)
        {
            view_answer_label.Content += "2";
        }

        private void Button_Click_Three(object sender, RoutedEventArgs e)
        {
            view_answer_label.Content += "3";
        }

        private void Button_Click_Zero(object sender, RoutedEventArgs e)
        {
            view_answer_label.Content += "0";
        }

        private void Button_Click_Dot(object sender, RoutedEventArgs e)
        {
            view_answer_label.Content += ".";
        }

        private void Button_Click_Clear_All(object sender, RoutedEventArgs e)
        {
            view_answer_label.Content = "0";
        }

        private void Button_Click_Get_Answer(object sender, RoutedEventArgs e)
        {
            view_answer_label.Content = answer;
        }
    }
}
