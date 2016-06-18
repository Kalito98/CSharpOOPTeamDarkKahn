namespace Clinic
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Doctor
    {
        const byte maxPatients = 10;
        const byte defaultPatients = 0;

        byte numPatients;
        private string name;
        private string phone;
        private string email;
        private List<Patient> doctorPatients;

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }
            private set
            {
                this.phone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            private set
            {
                this.email = value;
            }
        }

        Doctor(string name, string phone, string email)
        {
            this.doctorPatients = new List<Patient>();
            this.name = name;
            this.phone = phone;
            this.numPatients = defaultPatients;
            this.email = email;       
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
            for (int i = 0; i < this.phone.Length; i++)
            {
                if (!char.IsNumber(phone[i]))
                {
                    return false;
                }
            }
            Regex rgxEmail = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                               @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                               @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            return rgxEmail.IsMatch(email);
        }

        public void getInfoDoctor()
        {
            Console.WriteLine("Name: {0}",this.name);
            Console.WriteLine("Phone: {0}",this.phone);
            Console.WriteLine("E-mail: {0}",this.email);
        }

        public bool hasEnoughPatients()
        {
            if (numPatients >= maxPatients)
            {
                return false;
            }
            return true;
        }

        public void addNewPatient(Patient newPatient)
        {
            doctorPatients.Add(newPatient);
            numPatients++;
        }
    }
}
