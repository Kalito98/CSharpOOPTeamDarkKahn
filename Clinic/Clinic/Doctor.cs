using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApplication2
{
    class Doctor
    {
        private string name;
        private string phone;
        private string email;

        Doctor(string name, string phone, string email)
        {
            this.DoctorPatients = new List<Patient>();       
        }

        public bool IsLegitDoctorsVariables()
        {
            string nameCopy = this.name;
            string[] nameCopySplit = nameCopy.Split(' ');
            for (int i = 0; i < nameCopySplit.Length; i++)
            {
                for (int j = 0; j < nameCopySplit[i].Length; j++)
                {
                    if (!char.IsLetter(nameCopySplit[i][j]))
                    {
                        return false;
                    }
                }
            }
            for (int i = 0; i < phone.Length; i++)
            {
                if (!char.IsNumber(phone[i]))
                {
                    return false;
                }
            }
            //try
            //{
            //    var addr = new System.Net.Mail.MailAddress(email);
            //    return addr.Address == email;
            //}
            //catch
            //{
            //    return false;
            //}
            Regex rgxEmail = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                               @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                               @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            return rgxEmail.IsMatch(email);
        }

        public void addNewPatient(Patient newPatient)
        {
            DoctorPatients.Add(newPatient);
        }

        public List<Patient> DoctorPatients { get; private set; }
    }
}
