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

namespace cs013
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

        private void OrderBtn_Click(object sender, RoutedEventArgs e) {
            double total = 0;
            string bread = "";
            string meat = "";
            string size = "";
            string cheese = "";
            string veg = "";
            bool deal = false;
            if (six.IsChecked == true) { total += 3.5; size = "Six Inch "; }
            if (foot.IsChecked == true) { total += 5; size = "Foot Long "; }
            if (b1.IsChecked == true) { bread = "Wheat Bread "; }
            if (b2.IsChecked == true) { bread = "Italian Bread "; }
            if (b3.IsChecked == true) { total += .5; bread = "Flat Bread ";  }
            if (m1.IsChecked == true) { meat = "Ham "; }
            if (m2.IsChecked == true) { meat = "Roast Chickem "; }
            if (m3.IsChecked == true) { total += 1; meat = "Meat Balls "; }
            if (m4.IsChecked == true) { total += 1.5; meat = "Steak "; }
            if (c1.IsChecked == true) { total += .25; cheese += "American "; } 
            if (c2.IsChecked == true) { total += .3; cheese = cheese + "Swiss "; } 
            if (c3.IsChecked == true) { total += .75; cheese = cheese + "Pepper Jack "; }
            if (v1.IsChecked == true) { veg = "Cucumber "; }
            if (v2.IsChecked == true) { total += .25; veg += "Green Pepper "; }
            if (v3.IsChecked == true) { total += .15; veg += "Lettuce "; }
            if (v4.IsChecked == true) { total += .10; veg += "Red Onion"; }
            if (b1.IsChecked == true && foot.IsChecked == true && m3.IsChecked == true && c1.IsChecked == true) {
                deal = true;
                total -= 2;
            }
            totalLabel.Content = "Total: " + total.ToString("#.#0");
            orderLabel.Content = size + bread + meat + cheese + veg + (deal?" $2 off":"");
        }

        private void vall_Checked(object sender, RoutedEventArgs e) {
            v1.IsChecked = true;
            v2.IsChecked = true;
            v3.IsChecked = true;
            v4.IsChecked = true;
        }

        private void vall_UnChecked(object sender, RoutedEventArgs e) {
            v1.IsChecked = false;
            v2.IsChecked = false;
            v3.IsChecked = false;
            v4.IsChecked = false;
        }
    }
}
