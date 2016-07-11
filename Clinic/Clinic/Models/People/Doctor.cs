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

        public Speciality Speciality { get; set; }

        public Doctor(ContactInfo contactInfo, IList<IPatient> doctorPatients) : base(contactInfo)
        {
            this.doctorPatients = doctorPatients;
        }

        public Doctor(ContactInfo contactInfo) : base(contactInfo)
        {
        }

        public override string GetFullContactInfo()
        { 
            return this.ContactInfo + "\n Speciality: " + this.Speciality.Name;
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
            this.doctorPatients.Add(newPatient);
        }
    }
}