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
=======
           //  Some testing for the appointments
            // Doctor testDoctor = new Doctor("Cuki", "69696969", "test@abv.bg");
            // Patient testPatient = new Patient();
            // Appointments test = new Appointments("69", testPatient, testDoctor, "Planned", 45, "16:40", "2016.08.19");
            // DateTime testDateTime = test.PlannedDateAndTime;
            // test.GetApointmentInfo();
>>>>>>> dfb236cf383e1b93e99bc325309edfa7c5d55acc
        }
    }
}
