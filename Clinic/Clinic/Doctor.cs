using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Doctor
    {
        private string name;
        private string phone;
        private string email;
        private List<Patient> doctorPatients = new List<Patient>();

        public void addNewPatient(Patient newPatient)
        {
            doctorPatients.Add(newPatient);
        }

        
    }
}
