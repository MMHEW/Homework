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
using DoctorForm.Model;

namespace DoctorForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Refresh();
        }


        public void Refresh()
        {
            List<DoctorClass> doctor  = new List<DoctorClass>();

            using (HospitalEntities db = new HospitalEntities()) //opening connection to DB
            {
                doctor = (from obj in db.Patients
                            select new DoctorClass
                            {
                                Id = obj.Id,
                                First_Name = obj.First_Name,
                                Last_Name = obj.Last_Name,
                                Age = obj.Age,
                                Weight = obj.Weight,
                                Height = obj.Height
                               
                            }).ToList();
                DataGrid.ItemsSource = doctor;
            }

        }

        private void DeletePatient(object sender, RoutedEventArgs e)
        {

            Button MyButton = (Button)sender;

            int ButtonID = (int)MyButton.CommandParameter;

            using (HospitalEntities db = new HospitalEntities())
            {
                Patient oPatient = db.Patients.Find(ButtonID);
                db.Patients.Remove(oPatient);

                db.SaveChanges();
            }
            Refresh();

        }
    }

    public class DoctorClass
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public int Age { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
    }
}
