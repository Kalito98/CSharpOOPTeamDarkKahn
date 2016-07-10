namespace Clinic.Models.Procedures
{
    using Interfaces;
    using Common;
    using Validation;
    public class Procedure
    {
        private string name;
        private string description;
        private decimal price;
        private string idNumber;
        private IDoctor doctor;
        private IPatient patient;

        public Procedure(string name, string description, decimal price, string idNumber, IDoctor doctor,
            IPatient patient)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.IdNumber = idNumber;
            this.doctor = doctor;
            this.patient = patient;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                StringValidators.CheckIfStringIsNullOrEmpty(value,
                    string.Format(GlobalErrorMessages.NullObjectErrorMessage, "Procedure"));
                this.name = value;
            }
        }

        public string Description
        {
            get { return this.description; }
            set
            {
                StringValidators.CheckIfStringIsNullOrEmpty(value,
                    string.Format(GlobalErrorMessages.NullObjectErrorMessage, "Description"));
                this.description = value;
            }
        }


        public decimal Price
        {
            get { return this.price; }
            set
            {
                ObjectValidator.CheckIfLessThanZero(value,
                    string.Format(GlobalErrorMessages.NumberLessThanZeroErrorMessage, "Treatment price"));
                this.price = value;
            }
        }

        public string IdNumber
        {
            get { return this.idNumber; }
            private set
            {
                StringValidators.CheckIfStringLengthIsValid(value, min: 4,
                    message: string.Format(GlobalErrorMessages.StringTooShortErrorMessage, "ID number", 4));
                this.idNumber = value;
            }
        }
    }
}