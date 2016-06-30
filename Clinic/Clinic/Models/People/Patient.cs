namespace ConsoleApplication2.Models.People
{
    using System;
    using Common;
    using Validation;
    using Diseases;
    using System.Collections.Generic;

    public class Patient : Person
    {
        private string _pid;
        private List<Diseases> diseases;

        public List<Diseases> Diseases
        {
            get { return diseases; }
            set { diseases = value; }
        }

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

        

        public Patient(ContactInfo contactInfo, string pid) : base(contactInfo)
        {
            this.Pid = pid;
        }
    }
}