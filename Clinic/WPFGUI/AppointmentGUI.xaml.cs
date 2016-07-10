using Clinic.Models.Common;

namespace WPFGUI
{
    using System;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;

    using Clinic;
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

                    //GUIData.appointments.Add(new Appointments(textBox.Text, patient, doctor, comboBox2.Text, int.Parse(textBox6.Text), textBox4.Text + ":" + textBox5.Text, textBox3.Text + "." + textBox2.Text + "." + textBox1.Text));
                    Clinic.Instance.AddAppointment(new Appointments(textBox.Text, patient, doctor, comboBox2.Text, int.Parse(textBox6.Text), textBox4.Text + ":" + textBox5.Text, textBox3.Text + "." + textBox2.Text + "." + textBox1.Text));
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
            comboBox.ItemsSource = Clinic.Instance.Patients;//GUIData.patients;
            comboBox.SelectedIndex = 0;
        }

        private void comboBox1_Loaded(object sender, RoutedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            comboBox.ItemsSource = Clinic.Instance.Doctors;//GUIData.doctors;
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
            Canceled.Content = "Canceled";
            comboBox2.Items.Add(Canceled);

           // List<string> enumStatus = new List<string>();
           // enumStatus.Add("Planned");
           // enumStatus.Add("Completed");
           // enumStatus.Add("Canceled");
           // comboBox.ItemsSource = enumStatus;
            comboBox.SelectedIndex = 0;
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //currentPatient = GUIData.patients[comboBox.SelectedIndex];
            currentPatient = Clinic.Instance.Patients[comboBox.SelectedIndex];
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //currentDoctor = GUIData.doctors[comboBox1.SelectedIndex];
            currentDoctor = Clinic.Instance.Doctors[comboBox1.SelectedIndex];

        }

        private void comboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
