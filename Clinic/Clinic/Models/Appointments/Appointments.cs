namespace ConsoleApplication2.Models.Appointments
{
    using System;
    using System.Globalization;
    using People;

    public class Appointments
    {
        private string appointmentNumber;
        private DateTime plannedDateAndTime;
        private Patient patient;
        private Doctor doctor;
        private string status;
        private int plannedTime; //in minutes 

        public string AppointmentNumber
        {
            private set { this.appointmentNumber = value; }
            get { return appointmentNumber; }
        }

        public string Status
        {
            private set { this.status = value; }
            get { return status; }
        }

        public int PlannedTime
        {
            private set { this.plannedTime = value; }
            get { return plannedTime; }
        }

        public DateTime PlannedDateAndTime
        {
            get { return this.plannedDateAndTime; }
        }

        public Patient Patient
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Doctor Doctor
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Appointments(string appointmentNumber, Patient patient, Doctor doctor, string status,
            int plannedTime, string time, string date)
        {
            this.appointmentNumber = appointmentNumber;
            this.patient = patient;
            this.doctor = doctor;
            this.status = status;
            this.plannedTime = plannedTime;
            this.plannedDateAndTime = FormatDate(date, time);
        }

        private DateTime FormatDate(string date, string time)
        {
            string input = time + " " + date;
            string formatDate = "HH:mm yyyy.MM.dd";
            DateTime returnDate = DateTime.ParseExact(input, formatDate, CultureInfo.InvariantCulture);
            return returnDate;
        }

        public void GetApointmentInfo()
        {
            Console.WriteLine("№: " + appointmentNumber);
            Console.WriteLine("Status: " + status);
            Console.WriteLine("Patient: "); //waiting implementation
            Console.WriteLine("Doctor: " + doctor.Name);
            Console.WriteLine("Time: " + plannedTime + " Minutes");
            Console.WriteLine("Appointment planned for: " + plannedDateAndTime);
        }

        public enum StatusEnum
        {
            Planned = 0,
            Completed = 1,
            Canceled = 2
        }
    }
}