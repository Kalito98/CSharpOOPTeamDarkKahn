namespace ConsoleApplication2.Models.People
{
    using System.Collections.Generic;
    using Speciality;
    using Common;

    public class Doctor : Person
    {
        const byte MaxPatients = GlobalConstants.MaxPatientsPerDoctor;

        private List<Patient> doctorPatients;

        public int NumPatients
        {
            get { return this.doctorPatients.Count; }
            
        }

        public List<Patient> DoctorPatients
        {
            get { return doctorPatients; }
            set { doctorPatients = value; }
        }

        public Speciality Speciality
        {
            get { throw new System.NotImplementedException(); }

            set { }
        }

        public Doctor(ContactInfo contactInfo, byte numPatients, List<Patient> doctorPatients) : base(contactInfo)
        {

            this.doctorPatients = doctorPatients;
        }


        public string GetInfoDoctor()
        {
            return this.ContactInfo.ToString();
        }

        public bool HasEnoughPatients()
        {
            if (NumPatients >= MaxPatients)
            {
                return false;
            }
            return true;
        }

        public void AddNewPatient(Patient newPatient)
        {
            doctorPatients.Add(newPatient);
        }
    }
}