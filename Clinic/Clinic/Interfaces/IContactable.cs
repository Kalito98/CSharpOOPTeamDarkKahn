namespace Clinic.Interfaces
{
    using Models.People;

    public interface IContactable
    {
        ContactInfo ContactInfo { get; }

        string GetFullContactInfo();
    }
}