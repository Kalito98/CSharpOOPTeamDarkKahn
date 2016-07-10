
namespace WPFGUI
{
    using System.Windows;
    using System.Windows.Controls;

    using Clinic.Models.Appointments;
    using Clinic.Interfaces;
    using Clinic;

    /// <summary>
    /// Interaction logic for AppointmentsGetGUI.xaml
    /// </summary>
    public partial class AppointmentsGetGUI : Window
    {
        IAppointments currentSelection;
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
            comboBox.ItemsSource = Clinic.Instance.Appointments;
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
            textBox5.Text = currentSelection.Status.ToString();
        }
    }
}
