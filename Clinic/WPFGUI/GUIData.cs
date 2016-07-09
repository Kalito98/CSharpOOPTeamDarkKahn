using ConsoleApplication2.Models.Appointments;
using ConsoleApplication2.Models.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFGUI
{
    public static class GUIData
    {
        public static List<Doctor> doctors = new List<Doctor>();
        public static List<Patient> patients = new List<Patient>();
        public static List<Appointments> appointments = new List<Appointments>();    
    }
}
