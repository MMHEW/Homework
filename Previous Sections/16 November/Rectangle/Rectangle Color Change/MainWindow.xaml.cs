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

namespace Rectangle_Color_Change
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

        private void ChangeToPink(object sender, RoutedEventArgs e)
        {
            myRectangle.Fill = new SolidColorBrush(System.Windows.Media.Colors.Pink);
            textBlock.Text = "Brown";
        }
        private void ChangeToGreen(object sender, RoutedEventArgs e)
        {
            myRectangle.Fill = new SolidColorBrush(System.Windows.Media.Colors.Green);
            textBlock.Text = "Pink";
        }
        private void ChangeToAliceBlue(object sender, RoutedEventArgs e)
        {
            myRectangle.Fill = new SolidColorBrush(System.Windows.Media.Colors.AliceBlue);
            textBlock.Text = "Red";
        }
        private void ChangeToRed(object sender, RoutedEventArgs e)
        {
            myRectangle.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
            textBlock.Text = "Blue";
        }

    }
}
