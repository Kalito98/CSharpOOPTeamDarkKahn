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
        private DateTime dateOfBirth;
        private List<Diseases> _diseases;

        public Patient(ContactInfo contactInfo, string pid) : base(contactInfo)
        {
            this.Pid = pid;
            this.DateOfBirth = ExtractDateOfBirthFromEgn(pid);
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            private set { dateOfBirth = value; }
        }

        public List<Diseases> Diseases
        {
            get { return _diseases; }
            private set { _diseases = value; }
        }

        public string Pid
        {
            get { return _pid; }
            private set
            {
                if (EgnValidator.IsEgnValid(value))
                {
                    _pid = value;
                }
                else
                {
                    throw new ArgumentException(GlobalErrorMessages.InvalidEgnErrorMessage);
                }
            }
        }

        private static DateTime ExtractDateOfBirthFromEgn(string egn)
        {
            var year = int.Parse(egn.Substring(0, 2));
            var month = int.Parse(egn.Substring(2, 2));
            var day = int.Parse(egn.Substring(4, 2));

            if ( month > 40 )
            {
                month -= 40;
                year += 2000;
            }
            else if ( month > 20 )
            {
                month -= 20;
                year += 1800;
            }
            else
            {
                year += 1900;
            }
            return new DateTime(year, month, day);
        }


    }
}