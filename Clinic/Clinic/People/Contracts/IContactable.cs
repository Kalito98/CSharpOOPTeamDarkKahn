namespace ConsoleApplication2.People.Contracts
{
    public interface IContactable
    {
        ContactInfo PersonalInfo { get; set; }

        string GetFullContactInfo();
    }
}
