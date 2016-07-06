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
    /// Interaction logic for AppointmentGUI.xaml
    /// </summary>
    public partial class AppointmentGUI : Window
    {
        public AppointmentGUI()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
           // comboBox.DisplayMemberPath = "Key";
           // comboBox.SelectedValuePath = "Value";
           // comboBox.Items.Add(new KeyValuePair<string, string>("Something", "WhyNot"));
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //TODO: Everything
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void comboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
