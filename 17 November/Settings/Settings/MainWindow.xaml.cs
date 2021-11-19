using System;
using System.ComponentModel;
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
using System.Diagnostics;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Settings
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        Setting setting1;
        Setting setting2;
        Setting setting3;
        
        
        public bool wasS1 = true;
        public bool wasS2 = false;
        public bool wasS3 = false;

        public MainWindow()
        {
            setting1 = new Setting();
            setting2 = new Setting();
            setting3 = new Setting();         
           
            InitializeComponent();
            
        }

        public void buttonClicked(object a, RoutedEventArgs e)
        {

            DataContext = setting1;


        }

        public void buttonClicked1(object a, RoutedEventArgs e)
        {

            DataContext = setting2;


        }

        public void buttonClicked2(object a, RoutedEventArgs e)
        {

            DataContext = setting3;

           

        }


    }

    public class Setting : INotifyPropertyChanged
    {
            private double brightness0;
            private bool difficultyE0;
            private bool difficultyM0;
            private bool difficultyH0;
            private bool hints0;

            public double Brightness0 { get {return brightness0; } set{ brightness0 = value; updateUI("Brightness0"); } }


            public bool DifficultyE0 { get { return difficultyE0; } set { difficultyE0 = value; updateUI("DifficultyE0"); } }

            public bool DifficultyM0 { get { return difficultyM0; } set { difficultyM0 = value; updateUI("DifficultyM0"); } }

            public bool DifficultyH0 { get { return difficultyH0; } set { difficultyH0 = value; updateUI("DifficultyH0"); } }

            public bool Hints0 { get { return hints0; } set { hints0 = value; updateUI("Hints0"); } }


            public Setting(double bright = 50, bool easy = true, bool medium= false, bool hard = false, bool hint = true)
            {
                this.brightness0 = bright;
                this.difficultyE0 = easy;
                this.difficultyM0 = medium;
                this.difficultyH0 = hard;
                this.hints0 = hint;
            }

            public event PropertyChangedEventHandler? PropertyChanged;

            public void updateUI(string property = "")
            {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }                
        }
    }

