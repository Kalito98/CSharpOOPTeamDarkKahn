using System;

namespace Clinic.Interfaces
{
    public interface IAppointments
    {
        string AppointmentNumber { get; }
        string Status { get; }
        int PlannedTime { get; }
        DateTime PlannedDateAndTime { get; set; }
        IPatient Patient { get; set; }
        IDoctor Doctor { get; set; }
        void GetApointmentInfo();
    }
}