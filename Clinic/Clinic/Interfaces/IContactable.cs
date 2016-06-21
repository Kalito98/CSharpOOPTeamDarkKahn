namespace ConsoleApplication2.Interfaces
{
    using Models.People;

    public interface IContactable
    {
        ContactInfo ContactInfo { get; set; }

        string GetFullContactInfo();
    }
}