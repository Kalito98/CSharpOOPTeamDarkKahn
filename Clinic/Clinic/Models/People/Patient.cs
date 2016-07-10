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

        public Patient(ContactInfo contactInfo, string egn) : base(contactInfo)
        {
            this.Egn = egn;
            this.DateOfBirth = ExtractDateOfBirthFromEgn(this.Egn);
            this.Diseases = new List<Disease>();
        }

        public DateTime DateOfBirth { get; }

        public ICollection<Disease> Diseases { get; }

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

        public override string GetFullContactInfo()
        {
            return this.ContactInfo.ToString();
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