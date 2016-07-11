namespace WPFGUI
{
    using System.Windows;
    using System.Windows.Controls;

    using Clinic;
    using Clinic.Interfaces;
    using Clinic.Models.People;

    /// <summary>
    /// Interaction logic for PatientGetGUI.xaml
    /// </summary>
    public partial class PatientGetGUI : Window
    {
        private IPatient currentSelection;
        public PatientGetGUI()
        {
            InitializeComponent();
        }

        private void comboBox_Loaded(object sender, RoutedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            comboBox.ItemsSource = Clinic.Instance.Patients;
            comboBox.SelectedIndex = 0;
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var comoBox = sender as ComboBox;
            currentSelection = (Patient)comboBox.SelectedItem;
            textBox.Text = currentSelection.ContactInfo.FirstName;
            textBox1.Text = currentSelection.ContactInfo.MiddleName;
            textBox2.Text = currentSelection.ContactInfo.LastName;
            textBox3.Text = currentSelection.ContactInfo.Email;
            textBox4.Text = currentSelection.ContactInfo.PhoneNumber;
            textBox5.Text = currentSelection.Egn;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
