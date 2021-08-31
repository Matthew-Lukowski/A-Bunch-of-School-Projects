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

namespace BlackOutDatesChallengeMAL
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

        private void btn_Click(object sender, RoutedEventArgs e) {

            if (cal1.SelectedDate.HasValue && cal2.SelectedDate.HasValue) {
                DateTime x = cal1.SelectedDate.Value;
                DateTime y = cal2.SelectedDate.Value;
                label.Content = (y-x).Days;
                cal3.BlackoutDates.Clear();
                cal3.BlackoutDates.Add(new CalendarDateRange(x,y));
                
            }

        }

        private void cal1_SelectedDatesChanged(object sender, SelectionChangedEventArgs e) {
            d1.Content = cal1.SelectedDate.Value;
        }

        private void cal2_SelectedDatesChanged(object sender, SelectionChangedEventArgs e) {
            d2.Content = cal2.SelectedDate.Value;
        }
    }
}
