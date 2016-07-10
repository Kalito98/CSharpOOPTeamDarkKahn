namespace Clinic.Models.People
{
    using System;
    using System.Collections.Generic;
    using Validation;
    using Interfaces;
    using Diseases;
    using Common;

    public class Patient : Person, IPatient
    {
        private string _pid;
        private DateTime _dateOfBirth;
        private ICollection<Disease> _diseases;

        public Patient(ContactInfo contactInfo, string pid) : base(contactInfo)
        {
            this.Pid = pid;
            this.DateOfBirth = ExtractDateOfBirthFromEgn(pid);
        }

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            private set { _dateOfBirth = value; }
        }

        public ICollection<Disease> Diseases
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
                    throw new ArgumentException(string.Format(GlobalErrorMessages.InvalidStringErrorMessage, "EGN"));
                }
            }
        }

        public static DateTime ExtractDateOfBirthFromEgn(string egn)
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