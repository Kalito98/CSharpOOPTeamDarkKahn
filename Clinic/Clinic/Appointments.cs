namespace Clinic
{
    using System;
    using System.Globalization;

    public class Appointments
    {
        private DateTime plannedDateAndTime;
        private Patient patient;
        private string doctor;          //Replace after class Doctor 
        private Status status;
        private int plannedTime;        //in minutes 

        public Appointments(Patient patient, string doctor, Status status, int plannedTime, string time, string date)
        {
            this.patient = patient;
            this.doctor = doctor;
            this.status = status;
            this.plannedTime = plannedTime;
            this.plannedDateAndTime = FormatDate(date, time);
        }

        public DateTime PlannedDateAndTime
        {
            get { return this.plannedDateAndTime; }
        }

        private DateTime FormatDate(string date, string time)
        {
            string input = time + " " + date;
            string formatDate = "HH:mm yyyy.MM.dd";
            DateTime returnDate = DateTime.ParseExact(input, formatDate, CultureInfo.InvariantCulture);
            return returnDate;
        }

        public enum Status
        {
            Planned = 0,
            Completed = 1,
            Canceled = 2
        }
    }
}
