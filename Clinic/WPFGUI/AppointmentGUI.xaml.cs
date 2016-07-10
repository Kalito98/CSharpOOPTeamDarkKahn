
namespace WPFGUI
{
    using System;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;

    using Clinic;
    using Clinic.Models.Common;
    using Clinic.Models.Appointments;
    using Clinic.Models.People;
    using Clinic.Interfaces;
    using Clinic.Validation;

    /// <summary>
    /// Interaction logic for AppointmentGUI.xaml
    /// </summary>
    public partial class AppointmentGUI : Window
    {
        private IPatient currentPatient;
        private IDoctor currentDoctor;
        public AppointmentGUI()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you want to add this appointment?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    //Ugly bugfix when there is no patient or doctor selected..
                    var patient = (Patient) comboBox.SelectedItem;
                    var doctor = (Doctor) comboBox1.SelectedItem;
                    ObjectValidator.CheckIfObjectIsNull(patient, string.Format(GlobalErrorMessages.NullObjectErrorMessage, "Patient"));
                    ObjectValidator.CheckIfObjectIsNull(doctor, string.Format(GlobalErrorMessages.NullObjectErrorMessage, "Doctor"));

                    Clinic.Instance.AddAppointment(new Appointments(textBox.Text.Trim(), patient, doctor, Appointments.EnumConverter(comboBox2.Text), int.Parse(textBox6.Text.Trim()), textBox4.Text.Trim() + ":" + textBox5.Text.Trim(), textBox3.Text.Trim() + "." + textBox2.Text.Trim() + "." + textBox1.Text.Trim()));
                    textBox.Text = string.Empty;
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
                    textBox3.Text = string.Empty;
                    textBox4.Text = string.Empty;
                    textBox5.Text = string.Empty;
                    textBox6.Text = string.Empty;
                    MessageBox.Show("Successfully added new appointment!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void comboBox_Loaded(object sender, RoutedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            comboBox.ItemsSource = Clinic.Instance.Patients;
            comboBox.SelectedIndex = 0;
        }

        private void comboBox1_Loaded(object sender, RoutedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            comboBox.ItemsSource = Clinic.Instance.Doctors;
            comboBox.SelectedIndex = 0;
        }

        private void comboBox2_Loaded(object sender, RoutedEventArgs e)
        {
            var comboBox = sender as ComboBox;

            ComboBoxItem Planned = new ComboBoxItem();
            Planned.Background = Brushes.Yellow;
            Planned.Content = "Planned";
            comboBox2.Items.Add(Planned);

            ComboBoxItem Completed = new ComboBoxItem();
            Completed.Background = Brushes.Green;
            Completed.Content = "Completed";
            comboBox2.Items.Add(Completed);

            ComboBoxItem Canceled = new ComboBoxItem();
            Canceled.Background = Brushes.Red;
            Canceled.Content = "Cancelled";
            comboBox2.Items.Add(Canceled);

            comboBox.SelectedIndex = 0;
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentPatient = Clinic.Instance.Patients[comboBox.SelectedIndex];
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentDoctor = Clinic.Instance.Doctors[comboBox1.SelectedIndex];

        }

        private void comboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
