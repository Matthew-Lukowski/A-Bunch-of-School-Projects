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

namespace RadioButtonChallengeMAL
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

        private void ButtonMain_Click(object sender, RoutedEventArgs e)
        {
            pencilimg.Opacity = 0.0;
            penimg.Opacity = 0.0;
            phoneimg.Opacity = 0.0;
            tabimg.Opacity = 0.0;

            if (btn1.IsChecked == true)
            {
                label.Content = "Pencil, Very Reliable";
                pencilimg.Opacity = 1.0;
            }
            else if (btn2.IsChecked == true)
            {
                label.Content = "Pen, Nice choice";
                penimg.Opacity = 1.0;
            }
            else if (btn3.IsChecked == true)
            {
                label.Content = "Phone, You must be from the future";
                phoneimg.Opacity = 1.0;
            }
            else if (btn4.IsChecked == true)
            {
                label.Content = "Tablet, welcome to 2020";
                tabimg.Opacity = 1.0;
            }
            else
            {
                label.Content = "Must pick one";
            }
        }
    }
}
