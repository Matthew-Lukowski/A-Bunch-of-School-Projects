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

namespace Grade_App_cs24
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double[] x = new double[5];
        double avg;
        double total;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            avg = 0;
            total = 0;
            fillarray();
            totalMethod();
            average();

            avgScore.Content = string.Format("Average: {0:0.##}", avg);
            totalScore.Content = "Total:" + total;
        }

        private void fillarray()
        {
            x[0] = Convert.ToDouble(grade1.Text);
            x[1] = Convert.ToDouble(grade2.Text);
            x[2] = Convert.ToDouble(grade3.Text);
            x[3] = Convert.ToDouble(grade4.Text);
            x[4] = Convert.ToDouble(grade5.Text);
        }

        private void average()
        {
            avg = total / 5;
        }

        private void totalMethod()
        {
            foreach (double a in x)
            {
                total += a;
            }
        }

    }
}
