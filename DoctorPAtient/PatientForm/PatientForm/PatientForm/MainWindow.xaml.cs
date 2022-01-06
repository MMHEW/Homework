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
using PatientForm.Model;

namespace PatientForm
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

        private void AddNewPatient(object sender, RoutedEventArgs e)
        {

            Patient oPatient= new Patient();

            oPatient.First_Name = FirstNameTxt.Text;
            oPatient.Last_Name = LastNameTxt.Text;
            oPatient.Age = int.Parse(AgeTxt.Text);
            oPatient.Weight = decimal.Parse(WeightTxt.Text);
            oPatient.Height = decimal.Parse(HeightTxt.Text);

            

            using (HospitalEntities db = new HospitalEntities()) //opening connection to DB
            {
                db.Patients.Add(oPatient);
                db.SaveChanges();
            }

           
        }
    }
}
