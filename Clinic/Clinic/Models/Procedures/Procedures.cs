namespace ConsoleApplication2.Models.Procedures
{
    using System;
    using People;
    public class Procedures
    {
        private string name;
        private string description;
        private decimal price;
        private string idNumber;
        private Doctor doctor;
        private Patient patient;


        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Procedure");
                }
                this.name = value;
            }
        }

        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Description");
                }
                this.name = value;
            }
        }


        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid Price");
                }
                this.price = value;
            }
        }

        public string IdNumber
        {
            private get { return this.idNumber; }
            set
            {
                if (idNumber.Length < 4)
                {
                    throw new ArgumentException("Number of procedure too short");

                }
                this.idNumber = value;
            }
        }

        public Procedures(string name, string description, decimal price, string idNumber, Doctor doctor, Patient patient)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.idNumber = idNumber;
            this.doctor = doctor;
            this.patient = patient;
        }
    }
}
