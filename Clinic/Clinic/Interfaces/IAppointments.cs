namespace Clinic.Interfaces
{
    using System;
    using Models.Appointments;
    public interface IAppointments
    {
        string AppointmentNumber { get; }
        StatusEnum Status { get; }
        int PlannedTime { get; }
        DateTime PlannedDateAndTime { get; set; }
        IPatient Patient { get; set; }
        IDoctor Doctor { get; set; }
        void GetApointmentInfo();
    }
}