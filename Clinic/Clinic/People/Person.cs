namespace ConsoleApplication2.People
{
    using People.Contracts;

    public abstract class Person : IContactable
    {
        public ContactInfo PersonalInfo { get; set; }

        protected Person(ContactInfo personalInfo)
        {
            PersonalInfo = personalInfo;
        }
    }
}
