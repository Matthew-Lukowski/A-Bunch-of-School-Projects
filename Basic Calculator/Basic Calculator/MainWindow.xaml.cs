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

namespace Basic_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            double firstNum = Convert.ToDouble(firstNumBox.Text), secondNum = Convert.ToDouble(secondNumBox.Text);
            ansTxt.Content = firstNum + secondNum;
        }

        private void subtractButton_Click(object sender, RoutedEventArgs e)
        {
            double firstNum = Convert.ToDouble(firstNumBox.Text), secondNum = Convert.ToDouble(secondNumBox.Text);
            ansTxt.Content = firstNum - secondNum;
        }

        private void multiplyButton_Click(object sender, RoutedEventArgs e)
        {
            double firstNum = Convert.ToDouble(firstNumBox.Text), secondNum = Convert.ToDouble(secondNumBox.Text);
            ansTxt.Content = firstNum * secondNum;
        }

        private void divideButton_Click(object sender, RoutedEventArgs e)
        {
            double firstNum = Convert.ToDouble(firstNumBox.Text), secondNum = Convert.ToDouble(secondNumBox.Text);
            ansTxt.Content = firstNum / secondNum;
        }

        private void modulusButton_Click(object sender, RoutedEventArgs e)
        {
            double firstNum = Convert.ToDouble(firstNumBox.Text), secondNum = Convert.ToDouble(secondNumBox.Text);
            ansTxt.Content = firstNum % secondNum;
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            firstNumBox.Text = "1st #";
            secondNumBox.Text = "2nd #";
            ansTxt.Content = "";
        }
    }
}
