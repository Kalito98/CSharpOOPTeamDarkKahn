namespace Clinic.Interfaces
{
    using System.Collections.Generic;
    using Models.Speciality;
    public interface IDoctor : IContactable
    {
        int NumPatients { get; }
        IList<IPatient> DoctorPatients { get; set; }
        Speciality Speciality { get; }
        void AddNewPatient(IPatient patient);
    }
}
