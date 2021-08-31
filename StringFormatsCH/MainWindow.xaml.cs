using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace StringFormats
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Strange fix for calendars having to be defocused.
        private void cal1(object sender, SelectionChangedEventArgs e) {
            Mouse.Capture(null);
        }
        private void cal2(object sender, SelectionChangedEventArgs e) {
            Mouse.Capture(null);
        }

        //Print Ticket Button Method
        private void Button_Click(object sender, RoutedEventArgs e) {


            tDriverLbl.Content = $"Driver - {driverLbl.Text}";

            //convert text boxes to numbers to be formated
            double ss = double.Parse(SSLbl.Text);
                //print numbers with format
                tSSNLbl.Content = string.Format("SSN: {0:000-00-0000}", ss);

            // do the same as above for SSN
            double pn = double.Parse(phoneLbl.Text);

                tPNLbl.Content = string.Format("Phone #: {0:(000)000-0000}", pn);

            // subtract miles to get total
            int miles = Convert.ToInt32(endMilesTxtBox.Text) - Convert.ToInt32(startMilesTxtBox.Text);

                tMilesLBL.Content = $"Total Miles: {miles}";

            // Subtract days to get total days.
            int days = Convert.ToInt32((c2.SelectedDate.Value - c1.SelectedDate.Value).Days);

                tDaysOutLbl.Content = $"Days Out: {days}";

            //Find whether truck is fridged and adjust pay accordingly.
            double pay = (fridgeChk.IsChecked == true) ? miles * .37 : miles * .25;

                tPayDueLbl.Content = string.Format("Pay Due: {0:c}", pay);
            // get vacation per 5 days.
            int vac = days / 5;

                tVacayLbl.Content = $"Vacation Earned: {vac} Days";
        }
    }
}
