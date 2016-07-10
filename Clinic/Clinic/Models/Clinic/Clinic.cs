namespace Clinic
{
    using System.Collections.Generic;
    using Interfaces;
    using Models.Appointments;
    public class Clinic
    {
        public static ICollection<IDoctor> doctors = new List<IDoctor>();
        public static ICollection<IPatient> patients = new List<IPatient>();
        public static ICollection<Appointments> appointments = new List<Appointments>();
    }
}
