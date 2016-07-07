namespace ConsoleApplication2.Models.Payment
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using People;
    using Diseases;
    using Validation;
    using Common;
    public class Payments : TreatmentPrices
    {
        public TreatmentPrices PriceToPay { get; private set; }
        public Doctor Doctor { get; private set; }
        public Patient Patient { get; private set; }
        public string diseases;


        public Payments(Doctor doctor, Patient patient, string diseases, string diseaseKind)
            : base(diseaseKind)
        {
            this.Doctor = doctor;
            this.Patient = patient;
            this.Diseases = diseases;
        }

        public string Diseases
        {
            get { return this.diseases; }
            set
            {
                StringValidators.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.ObjectCannotBeNull, this.diseases));
                StringValidators.CheckIfStringLengthIsValid(value, 20, 2, string.Format(GlobalErrorMessages.InvalidStringLength, this.diseases, 2, 20));
                this.diseases = value;
            }
        }


        public override string ToString()
        {
            var paymentsDetails = new StringBuilder();
            paymentsDetails.AppendLine("Customer details: ");
            paymentsDetails.AppendLine(new string('-', 40));
            paymentsDetails.Append("Customer name: ");

            paymentsDetails.Append(Patient.ContactInfo.FirstName + " " + Patient.ContactInfo.MiddleName + " " +
                                   Patient.ContactInfo.LastName);
            paymentsDetails.Append("Customer contacts: ");

            paymentsDetails.Append("Phone: " + Patient.ContactInfo.PhoneNumber + "  Email:" +
                                   Patient.ContactInfo.Email);

            paymentsDetails.AppendLine();
            paymentsDetails.AppendLine(new string('*', 40));

            paymentsDetails.Append("Doctor details: ");
            paymentsDetails.AppendLine(new string('-', 40));
            paymentsDetails.Append("Doctor name: " + Doctor.ContactInfo.FullName);


            paymentsDetails.Append("Customer contacts: ");
            paymentsDetails.Append("Phone: " + Doctor.ContactInfo.PhoneNumber + "  Email: " + Doctor.ContactInfo.Email);
            paymentsDetails.AppendLine(new string('-', 40));

            paymentsDetails.AppendLine();
            paymentsDetails.AppendLine(new string('*', 40));

            paymentsDetails.Append("Type of procedures: ");
            paymentsDetails.AppendLine(new string('-', 40));
            paymentsDetails.AppendLine(this.diseases);

            paymentsDetails.AppendLine();
            paymentsDetails.AppendLine(new string('*', 40));

            paymentsDetails.Append("Price to pay: ");
            paymentsDetails.AppendLine(new string('-', 40));
            paymentsDetails.AppendFormat("The total amout is: {0}", this.PriceToPay);

            return base.ToString();
        }

        internal void PrintPayments(IEnumerable<Payments> payments)
        {
            foreach (var payment in payments)
            {
                Console.WriteLine(payment);
                Console.WriteLine();
            }
        }
    }
}