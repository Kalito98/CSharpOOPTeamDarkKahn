namespace ConsoleApplication2.Models.Payment
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using People;
    using Diseases;

    public class Payments : TreatmentPrices
    {
        public TreatmentPrices PriceToPay { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public Diseases Diseases { get; set; }


        public Payments(Doctor doctor, Patient patient, Diseases diseases, string diseaseKind)
            : base(diseaseKind)
        {
            this.Doctor = doctor;
            this.Patient = patient;
            this.Diseases = diseases;
        }

        public static void PrintPayments(IEnumerable<Payments> payments)
        {
            foreach (var payment in payments)
            {
                Console.WriteLine(payment);
                Console.WriteLine();
            }
        }

        public override string ToString()
        {
            var paymentsDetails = new StringBuilder();
            paymentsDetails.AppendLine("Customer details: ");
            paymentsDetails.AppendLine(new string('-', 40));
            paymentsDetails.Append("Customer name: ");

            paymentsDetails.Append(Patient.PersonalInfo.FirstName + " " + Patient.PersonalInfo.MiddleName + " " +
                                   Patient.PersonalInfo.LastName);
            paymentsDetails.Append("Customer contacts: ");

            paymentsDetails.Append("Phone: " + Patient.PersonalInfo.PhoneNumber + "  Email:" +
                                   Patient.PersonalInfo.Email);

            paymentsDetails.AppendLine();
            paymentsDetails.AppendLine(new string('*', 40));

            paymentsDetails.Append("Doctor details: ");
            paymentsDetails.AppendLine(new string('-', 40));
            paymentsDetails.Append("Doctor name: " + Doctor.Name);


            paymentsDetails.Append("Customer contacts: ");
            paymentsDetails.Append("Phone: " + Doctor.Phone + "  Email: " + Doctor.Email);
            paymentsDetails.AppendLine(new string('-', 40));

            paymentsDetails.AppendLine();
            paymentsDetails.AppendLine(new string('*', 40));

            paymentsDetails.Append("Type of procedures: ");
            paymentsDetails.AppendLine(new string('-', 40));
            paymentsDetails.AppendLine(Diseases.DiseasesName);

            paymentsDetails.AppendLine();
            paymentsDetails.AppendLine(new string('*', 40));

            paymentsDetails.Append("Price to pay: ");
            paymentsDetails.AppendLine(new string('-', 40));
            paymentsDetails.AppendFormat("The total amout is: {0}", PriceToPay.CalculatePrice());

            return base.ToString();
        }
    }
}