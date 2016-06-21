namespace ConsoleApplication2.Models.People
{
    using System;
    using Interfaces;
    public abstract class Person : IContactable
    {
        public ContactInfo ContactInfo { get; set; }

        protected Person(ContactInfo contactInfo)
        {
            this.ContactInfo = contactInfo;
        }

        public string GetFullContactInfo()
        {
            //TODO:
            throw new NotImplementedException("No contact info yet");
            return $"{this.ContactInfo.FirstName}";
        }
    }
}