namespace Clinic.Interfaces
{
    using System;
    using System.Collections.Generic;

    using Models.Diseases;
    public interface IPatient : IContactable
    {
        DateTime DateOfBirth { get; }
        ICollection<Disease> Diseases { get; }
        string Pid { get; }
    }
}
