
namespace ConsoleApplication2.People
{
    using People.Contracts;

    public class Person : IContactable
    {
        public ContactInfo PersonalInfo { get; set; }

    }
}
