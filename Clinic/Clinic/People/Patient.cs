namespace ConsoleApplication2.People
{
    using System;
    using ConsoleApplication2.Common;
    using ConsoleApplication2.Validation;

    public class Patient: Person
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
