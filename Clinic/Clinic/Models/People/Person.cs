namespace Clinic.Models.People
{
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
            return this.ContactInfo.ToString();
        }
    }
}