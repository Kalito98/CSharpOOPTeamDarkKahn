using System;
using ConsoleApplication2.Models.Appointments;
using ConsoleApplication2.Models.People;
using System.Collections.Generic;
using ConsoleApplication2.Models.Diseases;
using ConsoleApplication2.Models.Payment;

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
            Patient testPatient = new Patient(new ContactInfo("test", "test2", "test3", "0888888888", "test@abv.bg"), "7104268410");
            Patient testPatient1 = new Patient(new ContactInfo("test", "test2", "test3", "0888888888", "test@abv.bg"), "0611244206");
            //Patient testPatient2 = new Patient(new ContactInfo("test", "test2", "test3", "0888888888", "test@abv.bg"), "1608059251");
            //Patient testPatient3 = new Patient(new ContactInfo("test", "test2", "test3", "0888888888", "test@abv.bg"), "5602050450");
            //Patient testPatient4 = new Patient(new ContactInfo("test", "test2", "test3", "0888888888", "test@abv.bg"), "7404258238");
            Patient testPatient5 = new Patient(new ContactInfo("test", "test2", "test3", "0888888888", "test@abv.bg"), "0643032846");
            //Appointments test = new Appointments("69", testPatient, testDoctor, Appointments.StatusEnum.Completed, 45, "16:40", "2016.08.19");
            //test.GetApointmentInfo();
            // DateTime testDateTime = test.PlannedDateAndTime;
            // test.GetApointmentInfo();
            Diseases testDiseases = new Diseases("88888", "Cavity", 1, 120.00M, true, GroupDiseases.Други);


            var customer1 = new Payments(testDoctor, testPatient, testDiseases.DiseasesName);
            var payments = new Payments[]
            {
                new Payments(testDoctor,testPatient,testDiseases.DiseasesName),
                new Payments(testDoctor,testPatient,testDiseases.DiseasesName ),
                new Payments(testDoctor,testPatient,testDiseases.DiseasesName),
                new Payments(testDoctor,testPatient,testDiseases.DiseasesName ),
                new Payments(testDoctor,testPatient,testDiseases.DiseasesName)
            };
            foreach (var item in payments)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
