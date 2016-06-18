namespace ConsoleApplication2.People
{
    using System;
    using Validation;

    public struct ContactInfo
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string email;
        private string phoneNumber;

        public ContactInfo(string firstName, string middleName, string lastName, string phoneNumber, string email = "")
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if ( string.IsNullOrEmpty(value) )
                {
                    throw new ArgumentException("First name cannot be empty!");
                }
                else
                {
                    this.firstName = value;
                }
            }
        }

        public string MiddleName
        {
            get { return middleName; }
            set
            {
                if ( string.IsNullOrEmpty(value) )
                {
                    throw new ArgumentException("Middle name cannot be empty!");
                }
                else
                {
                    this.middleName = value;
                }
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if ( string.IsNullOrEmpty(value) )
                {
                    throw new ArgumentException("Last name cannot be empty!");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (ObjectValidator.CheckIfEmailIsValid(value))
                {
                    email = value;
                }
                else
                {
                    throw new ArgumentException("The e-mail is invalid!");
                }
            }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
    }
}