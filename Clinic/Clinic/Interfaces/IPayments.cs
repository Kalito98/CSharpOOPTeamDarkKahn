namespace Clinic.Interfaces
{
    public interface IPayments
    {
        IDoctor Doctor { get;}

        IPatient Patient { get;}

        string Diseases { get;}
    }
}
