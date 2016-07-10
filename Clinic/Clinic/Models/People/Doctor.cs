namespace Clinic.Models.People
{
    using System.Collections.Generic;
    using Speciality;
    using Interfaces;
    using Common;

    public class Doctor : Person, IDoctor
    {
        const byte MaxPatients = GlobalConstants.MaxPatientsPerDoctor;

        private IList<IPatient> doctorPatients;

        public int NumPatients
        {
            get { return this.doctorPatients.Count; }
        }

        public IList<IPatient> DoctorPatients
        {
            get { return doctorPatients; }
            set { doctorPatients = value; }
        }

        public Speciality Speciality
        {
            get { throw new System.NotImplementedException(); }

            set { }
        }

        public Doctor(ContactInfo contactInfo, byte numPatients, IList<IPatient> doctorPatients) : base(contactInfo)
        {

            this.doctorPatients = doctorPatients;
        }

        public Doctor(ContactInfo contactInfo) : base(contactInfo)
        {
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

        public void AddNewPatient(IPatient newPatient)
        {
            doctorPatients.Add(newPatient);
        }
    }
}