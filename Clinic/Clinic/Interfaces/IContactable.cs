namespace ConsoleApplication2.Interfaces
{
    using Models.People;

    public interface IContactable
    {
        ContactInfo PersonalInfo { get; set; }

        string GetFullContactInfo();
    }
}