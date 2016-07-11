namespace Clinic.Models.Payment
{
    using System.Text;
    using Validation;
    using Interfaces;
    using Common;

    public class Payments : IPayments
    {
        private string diseases;

        public Payments(IDoctor doctor, IPatient patient, string diseases)
        {
            this.Doctor = doctor;
            this.Patient = patient;
            this.Diseases = diseases;
        }

        public IDoctor Doctor { get; private set; }
        public IPatient Patient { get; private set; }

        public string Diseases
        {
            get { return this.diseases; }
            set
            {
                StringValidators.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.ObjectCannotBeNull, this.diseases));
                StringValidators.CheckIfStringLengthIsValid(value, min: 2, max: 20, message: string.Format(GlobalErrorMessages.InvalidStringLength, this.diseases, 2, 20));
                this.diseases = value;
            }
        }

        public override string ToString()
        {
            var paymentsDetails = new StringBuilder();
            paymentsDetails.AppendLine("Customer details: ");
            paymentsDetails.AppendLine(new string('-', 40));
            paymentsDetails.AppendLine("Customer name: ");

            paymentsDetails.AppendLine(Patient.ContactInfo.FirstName + " " + Patient.ContactInfo.MiddleName + " " +
                                   Patient.ContactInfo.LastName);
            paymentsDetails.AppendLine("Customer contacts: ");

            paymentsDetails.AppendLine("Phone: " + Patient.ContactInfo.PhoneNumber + "  Email:" +
                                   Patient.ContactInfo.Email);

            paymentsDetails.AppendLine();
            paymentsDetails.AppendLine(new string('*', 40));

            paymentsDetails.AppendLine("Doctor details: ");
            paymentsDetails.AppendLine(new string('-', 40));
            paymentsDetails.AppendLine("Doctor name: " + Doctor.ContactInfo.FullName);


            paymentsDetails.AppendLine("Customer contacts: ");
            paymentsDetails.AppendLine("Phone: " + Doctor.ContactInfo.PhoneNumber + "  Email: " + Doctor.ContactInfo.Email);
            paymentsDetails.AppendLine(new string('-', 40));

            paymentsDetails.AppendLine();
            paymentsDetails.AppendLine(new string('*', 40));

            paymentsDetails.AppendLine("Type of procedures: ");
            paymentsDetails.AppendLine(new string('-', 40));
            paymentsDetails.AppendLine(this.diseases);

            paymentsDetails.AppendLine();
            paymentsDetails.AppendLine(new string('*', 40));

            paymentsDetails.AppendLine("Price to pay: ");
            paymentsDetails.AppendLine(new string('-', 40));
            paymentsDetails.AppendLine(string.Format("The total amout is: {0}",TreatmentPrices.CalculatePrice(this.diseases)));

            return paymentsDetails.ToString();
        }
    }
}