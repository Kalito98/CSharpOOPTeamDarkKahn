namespace Clinic
{
    using System.Collections.Generic;
    using Interfaces;

    public sealed class Clinic
    {
        private Clinic()
        {
            this.Doctors = new List<IDoctor>();
            this.Patients = new List<IPatient>();
            this.Appointments = new List<IAppointments>();
        }

        public static Clinic Instance { get; } = new Clinic();

        public IList<IDoctor> Doctors { get; }

        public IList<IPatient> Patients { get; }

        public IList<IAppointments> Appointments { get; }

        public void AddDoctor(IDoctor doc)
        {
            this.Doctors.Add(doc);
        }
        public void AddPatient(IPatient pac)
        {
            this.Patients.Add(pac);
        }
        public void AddAppointment(IAppointments app)
        {
            this.Appointments.Add(app);
        }
    }
}