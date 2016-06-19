using Payment;
using System;

namespace Clinic
{
    public class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
           Patient testPatient = new Patient();
           Appointments test = new Appointments(testPatient, "TestDoctor", 0, 45, "16:40", "2016.08.19");
           DateTime testDateTime = test.PlannedDateAndTime;
           Console.WriteLine(testDateTime);
           //  Some testing for the appointments
=======
            //  Some testing for the appointments
>>>>>>> fb942459e87606abe1e20913ec38d8c3d6cc82cb
            // Doctor testDoctor = new Doctor("Cuki", "69696969", "test@abv.bg");
            // Patient testPatient = new Patient();
            // Appointments test = new Appointments("69", testPatient, testDoctor, "Planned", 45, "16:40", "2016.08.19");
            // DateTime testDateTime = test.PlannedDateAndTime;
            // test.GetApointmentInfo();
<<<<<<< HEAD
=======
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
>>>>>>> fb942459e87606abe1e20913ec38d8c3d6cc82cb
        }
    }
}
