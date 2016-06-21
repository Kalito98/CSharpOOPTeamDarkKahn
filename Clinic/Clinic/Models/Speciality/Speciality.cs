﻿namespace ConsoleApplication2.Models.Speciality
{
    using System.Collections.Generic;
    using People;
    using Diseases;

    public class Speciality
    {
        private string name;
        private List<Doctor> specialityDoctors = new List<Doctor>();
        private List<Diseases> specialityDiseases = new List<Diseases>();

        public Speciality(List<Diseases> _speacialityDiseases, string name)
        {
            _speacialityDiseases = new List<Diseases>();
            this.specialityDiseases = _speacialityDiseases;
            this.name = name;
        }

        public void addDoctor(Doctor newSpecialityDoctor)
        {
            specialityDoctors.Add(newSpecialityDoctor);
        }
    }
}