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

namespace DeviceDemoSoftware
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
        //I would like to control each device inside its own class. 
        //You can put all of the controls and the reponses in this XAML
        //I would like the ability to turn on each device and use all of the controls for each device
        //I would like status information for each device 
        //You can create new tabs for each device control and have all settings and control in their repective tabs
        //my email is peterkeating1@outlook.com with any questions
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PassportScannerButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Camera2Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CreditCardReaderButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CashDispenserButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Camera1Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
