using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Speciality
    {
        private string name;
        private List<Doctor> specialityDoctors = new List<Doctor>();
        private List<Diseases> specialityDiseases = new List<Diseases>();

        public Speciality(List<Diseases> _speacialityDiseases)
        {
            _speacialityDiseases = new List<Diseases>();
            this.specialityDiseases = _speacialityDiseases;
        }

        public void addDoctor(Doctor newSpecialityDoctor)
        {
            specialityDoctors.Add(newSpecialityDoctor);
        }
    }
}
