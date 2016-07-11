﻿namespace Clinic.Models.Appointments
{
    using System;
    using System.Globalization;

    using Common;
    using Interfaces;

    public class Appointments : IAppointments
    {
        private string appointmentNumber;
        private DateTime plannedDateAndTime;
        private IPatient patient;
        private IDoctor doctor;
        private StatusEnum status;
        private int plannedTime; //in minutes 

        public Appointments(string appointmentNumber, IPatient patient, IDoctor doctor, StatusEnum status,
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
                    throw new ArgumentException(string.Format(GlobalErrorMessages.InvalidStringErrorMessage, "appointment number"));
                }
                else
                {
                    this.appointmentNumber = value;
                }
            }
        }

        public StatusEnum Status
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
                    throw new ArgumentException(string.Format(GlobalErrorMessages.InvalidStringErrorMessage, "planned time"));
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

        public IPatient Patient
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

        public IDoctor Doctor
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

        public static StatusEnum EnumConverter(string input)
        {
            switch (input)
            {
                case "Cancelled":
                    return StatusEnum.Canceled;
                case "Completed":
                    return StatusEnum.Completed;
                default:
                    return StatusEnum.Planned;
            }
        }

    }
}