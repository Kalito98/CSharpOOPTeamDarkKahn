using System;
using ConsoleApplication2.Models.Appointments;
using ConsoleApplication2.Models.People;
using System.Collections.Generic;

namespace Clinic
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Patient testPatient = new Patient();
            //Appointments test = new Appointments(testPatient, "TestDoctor", 0, 45, "16:40", "2016.08.19");
            //DateTime testDateTime = test.PlannedDateAndTime;
            //Console.WriteLine(testDateTime);
            //  Some testing for the appointments
            //  Some testing for the appointments
            Doctor testDoctor = new Doctor(new ContactInfo("test", "test2", "test3", "0888888888", "test@abv.bg"), 6, new List<Patient>());
            Patient testPatient = new Patient(new ContactInfo("test", "test2", "test3", "0888888888", "test@abv.bg"), "9211227221");
            Appointments test = new Appointments("69", testPatient, testDoctor, Appointments.StatusEnum.Completed, 45, "16:40", "2016.08.19");
            test.GetApointmentInfo();
            // DateTime testDateTime = test.PlannedDateAndTime;
            // test.GetApointmentInfo();
            //var payment=new Payments(testDoctor,testPatient,testDiseases, testDiseases.diseasesKind)
            //var payments = new List<Payments>()
            //{
            //    new Payments(testDoctor,testPatient,testDiseases, testDiseases.diseasesKind),
            //    new Payments(testDoctor1,testPatient1,testDiseases1, testDiseases1.diseasesKind),
            //    new Payments(testDoctor2,testPatient2,testDiseases2, testDiseases2.diseasesKind),
            //    new Payments(testDoctor3,testPatient3,testDiseases3, testDiseases3.diseasesKind),
            //    new Payments(testDoctor4,testPatient4,testDiseases4, testDiseases4.diseasesKind)
            //};
            //Payments.PrintPayments(payments);
        }
    }
}
