namespace ConsoleApplication2.People
{
    using System;
    using People.Contracts;

    public abstract class Person : IContactable
    {
        public ContactInfo PersonalInfo { get; set; }

        protected Person(ContactInfo personalInfo)
        {
            this.PersonalInfo = personalInfo;
        }

        public string GetFullContactInfo()
        {
            //TODO:
            throw new NotImplementedException("No contact info yet");
            return $"{this.PersonalInfo.FirstName}";
        }
    }
}
