using ConsoleApplication2.Models.Appointments;
using ConsoleApplication2.Models.People;
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
using static ConsoleApplication2.Models.Appointments.Appointments;

namespace WPFGUI
{
    /// <summary>
    /// Interaction logic for AppointmentGUI.xaml
    /// </summary>
    public partial class AppointmentGUI : Window
    {
        private Patient currentPatient;
        private Doctor currentDoctor;
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
                    GUIData.appointments.Add(new Appointments(textBox.Text, (Patient)comboBox.SelectedItem, (Doctor)comboBox1.SelectedItem, comboBox2.Text, int.Parse(textBox6.Text), textBox4.Text + ":" + textBox5.Text, textBox3.Text + "." + textBox2.Text + "." + textBox1.Text));
                    textBox.Text = string.Empty;
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
                    textBox3.Text = string.Empty;
                    textBox4.Text = string.Empty;
                    textBox5.Text = string.Empty;
                    textBox6.Text = string.Empty;
                    MessageBox.Show("Successfully added new appointment!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Information must be valid!");
                }
            }
        }

        private void comboBox_Loaded(object sender, RoutedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            comboBox.ItemsSource = GUIData.patients;
            comboBox.SelectedIndex = 0;
        }

        private void comboBox1_Loaded(object sender, RoutedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            comboBox.ItemsSource = GUIData.doctors;
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
            currentPatient = GUIData.patients[comboBox.SelectedIndex]; 
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentDoctor = GUIData.doctors[comboBox1.SelectedIndex];
        }

        private void comboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
