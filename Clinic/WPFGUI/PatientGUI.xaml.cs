namespace WPFGUI
{
    using System;
    using System.Windows;
    using Clinic;
    using Clinic.Models.People;
    /// <summary>
    /// Interaction logic for Patient.xaml
    /// </summary>
    public partial class PatientGUI : Window
    {
        public PatientGUI()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you want to add this patient?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    Clinic.Instance.AddPatient(new Patient(new ContactInfo(textBox.Text.Trim(), textBox1.Text.Trim(), textBox2.Text.Trim(), textBox4.Text.Trim(), textBox3.Text.Trim()), textBox5.Text.Trim()));
                    textBox.Text = string.Empty;
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
                    textBox3.Text = string.Empty;
                    textBox4.Text = string.Empty;
                    textBox5.Text = string.Empty;
                    MessageBox.Show("Successfully added new patient!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
