using Clinic.Models.Appointments;
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
using System.Windows.Shapes;

namespace WPFGUI
{
    /// <summary>
    /// Interaction logic for AppointmentsGetGUI.xaml
    /// </summary>
    public partial class AppointmentsGetGUI : Window
    {
        Appointments currentSelection;
        public AppointmentsGetGUI()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void comboBox_Loaded(object sender, RoutedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            comboBox.ItemsSource = GUIData.appointments;
            comboBox.SelectedIndex = 0;
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var comoBox = sender as ComboBox;
            currentSelection = (Appointments)comboBox.SelectedItem;
            textBox.Text = currentSelection.AppointmentNumber;
            textBox1.Text = currentSelection.PlannedDateAndTime.ToString();
            textBox2.Text = currentSelection.Patient.ContactInfo.FullName;
            textBox3.Text = currentSelection.Doctor.ContactInfo.FullName;
            textBox4.Text = currentSelection.PlannedTime.ToString();
            textBox5.Text = currentSelection.Status;
        }
    }
}
