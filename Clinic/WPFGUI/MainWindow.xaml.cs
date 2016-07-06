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
using ConsoleApplication2.Models.People;

namespace WPFGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Patient> patients = new List<Patient>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var patient = new PatientGUI();
            patient.Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var doctor = new DoctorGUI();
            doctor.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            var appointment = new AppointmentGUI();
            appointment.Show();
        }
    }
}