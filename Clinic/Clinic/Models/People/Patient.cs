namespace ConsoleApplication2.Models.People
{
    using System;
    using Common;
    using Validation;
    public class Patient : Person
    {
        private string _pid;

        public string Pid
        {
            get { return _pid; }
            set
            {
                if (EGNValidator.IsEGNValid(value))
                {
                    _pid = value;
                }
                else
                {
                    throw new ArgumentException(GlobalErrorMessages.InvalidEGNErrorMessage);
                }
            }
        }

        public Diseases.Diseases Diseases
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Patient(ContactInfo contactInfo, string pid) : base(contactInfo)
        {
            this.Pid = pid;
        }
    }
}