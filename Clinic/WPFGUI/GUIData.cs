namespace WPFGUI
{
    using System.Collections.Generic;
    using Clinic.Interfaces;
    public static class GUIData
    {
        public static IList<IDoctor> doctors = new List<IDoctor>();
        public static IList<IPatient> patients = new List<IPatient>();
        public static IList<IAppointments> appointments = new List<IAppointments>();    
    }
}
