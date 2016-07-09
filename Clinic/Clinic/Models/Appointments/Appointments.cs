namespace ConsoleApplication2.Models.Appointments
{
    using System;
    using System.Globalization;
    using People;
    using Common;

    public class Appointments
    {
        private string appointmentNumber;
        private DateTime plannedDateAndTime;
        private Patient patient;
        private Doctor doctor;
        private string status;
        private int plannedTime; //in minutes 

        public Appointments(string appointmentNumber, Patient patient, Doctor doctor, string status,
           int plannedTime, string time, string date)
        {
            this.AppointmentNumber = appointmentNumber;
            this.Patient = patient;
            this.Doctor = doctor;
            this.Status = status;
            this.PlannedTime = plannedTime;
            this.PlannedDateAndTime = FormatDate(date, time);
        }

        public string AppointmentNumber
        {
            get
            {
                return appointmentNumber;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(GlobalErrorMessages.InvalidAppointmentNumber);
                }
                else
                {
                    this.appointmentNumber = value;
                }
            }
        }

        public string Status
        {
            get
            {
                return status;
            }
            private set
            {
                this.status = value;
            }
        }

        public int PlannedTime
        {
            get
            {
                return plannedTime;
            }
            private set
            {
                if (string.IsNullOrEmpty(value.ToString()))
                {
                    throw new ArgumentException(GlobalErrorMessages.InvalidPalnnedTime);
                }
                else
                {
                    this.plannedTime = value;
                }
            }
        }

        public DateTime PlannedDateAndTime
        {
            get
            {
                return this.plannedDateAndTime;
            }
            set
            {
                this.plannedDateAndTime = value;
            }
        }

        public Patient Patient
        {
            get
            {
                return this.patient;
            }
            set
            {
                this.patient = value;
            }
        }

        public Doctor Doctor
        {
            get
            {
                return this.doctor;
            }
            set
            {
                this.doctor = value;
            }
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
            Console.WriteLine("Patient: " + patient.ContactInfo.FullName); 
            Console.WriteLine("Doctor: " + doctor.ContactInfo.FullName);
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