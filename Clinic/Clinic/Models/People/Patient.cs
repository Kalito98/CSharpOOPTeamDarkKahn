namespace Clinic.Models.People
{
    using System;
    using System.Collections.Generic;
    using Validation;
    using Interfaces;
    using Diseases;
    using Common;
    using Exceptions;

    public class Patient : Person, IPatient
    {
        private string _egn;
        private DateTime _dateOfBirth;
        private ICollection<Disease> _diseases;

        public Patient(ContactInfo contactInfo, string egn) : base(contactInfo)
        {
            this.Egn = egn;
            this.DateOfBirth = ExtractDateOfBirthFromEgn(this.Egn);
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

        public string Egn
        {
            get { return _egn; }
            private set
            {
                if (EgnValidator.IsEgnValid(value))
                {
                    _egn = value;
                }
                else
                {
                    throw new InvalidEgnException(string.Format(GlobalErrorMessages.InvalidStringErrorMessage, "EGN"));
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