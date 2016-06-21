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

        public Patient(ContactInfo personalInfo, string pid) : base(personalInfo)
        {
            this.Pid = pid;
        }
    }
}