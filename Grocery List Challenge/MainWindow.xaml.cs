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

namespace Grocery_List_Challenge {



    public partial class MainWindow : Window {

        string[] listarray;
        int num = 0;
        double total = 0;

        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            newlist();
            lblTellToAdd.Content = "Enter Items";
            btn1.Visibility = Visibility.Hidden;
            btn2.Visibility = Visibility.Visible;
        }



        private void Button_Click_1(object sender, RoutedEventArgs e) {
            if (num+1 == listarray.Length) lblTellToAdd.Content = "Press again to print list";
            if(num+1 < listarray.Length) lblTellToAdd.Content = "Enter Item: " + (num + 2);

            additem();           
        }



        private void newlist() {
            listarray = new string[Convert.ToInt32(tboxItemAmmount.Text)];
        }



        private void additem() {
            if (num < listarray.Length) {
                total += Convert.ToDouble(tboxItemPrice.Text);
                listarray[num] = tboxItemName.Text + string.Format(" {0:c}", Convert.ToDouble(tboxItemPrice.Text));
                num++;
            } else {
                foreach (string x in listarray) {
                    lblList.Content += x + "\n";
                }
                lblTotal.Content = string.Format("Total: {0:c}", total);
            }
            tboxItemPrice.Text = null;
            tboxItemName.Text = null;

        }





    }
}
