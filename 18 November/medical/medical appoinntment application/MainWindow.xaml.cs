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
using System.Diagnostics;

namespace medical_appoinntment_application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Patient p1;
        public Patient p2;
        public Patient p3;
        public Patient p4;

        public List<Patient> patient = new List<Patient>();
        
        public List<Patient> Patient { get { return patient; } set { patient = Patient; } }




        public MainWindow()
        {
            InitializeComponent();
            

            p1 = new Patient();
            p2 = new Patient();
            p3 = new Patient("Jane", "Doe", 36, "Female", "AB-", "Blood Is Straight Syrup", "Negative", "157", "61", "123-45-6789", "Nope :(");
            p4 = new Patient("Matthew", "Miller", 24, "A+","Male", "Nope", "Negative", "280", "73", "Nah", "Hell Yeah");

            patient.Add(p1);
            patient.Add(p2);
            patient.Add(p3);
            patient.Add(p4);

            DataContext = this;
        }

        public void ButtonPress(object sender, MouseButtonEventArgs e)
        {

            Debug.WriteLine("This Sucks");

        }
    }

    public class Patient
    {
        private string firstName;
        private string lastName;
        private string name;
        private int age;
        private string gender;
        private string bloodType;
        private string diabetes;
        private string hiv;
        private string weight;
        private string height;
        private string ssn;
        private string insurance;

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }

        public string Gender { get { return gender; } set { gender = value; } }
        public string BloodType { get { return bloodType; } set { bloodType = value; } }
        public string Diabetes { get { return diabetes; } set { diabetes = value; } }
        public string HIV { get { return hiv; } set { hiv = value; } }
        public string Weight { get { return weight; } set { weight = value; } }
        public string Height { get { return height; } set { height = value; } }
        public string SSN { get { return ssn; } set { ssn = value; } }
        public string Insurance { get { return insurance; } set { insurance = value; } }

        public Patient (string fname = "John", string lname = "Doe", int age = 24, string gen = "Apache Helicopter", string blood = "A+", string dia = "Yes", string hiV = "Yes", string w8 = "485", string hite = "73", string social = "154-57-7418", string ins = "Yes!")
        {
            this.firstName = fname;
            this.lastName = lname;
            this.name = fname + " " + lname;
            this.age = age;
            this.gender = gen;
            this.bloodType = blood;
            this.diabetes = dia;
            this.hiv = hiV;
            this.weight = w8;
            this.height = hite;
            this.ssn = social;
            this.insurance = ins;

        }

    }
}
