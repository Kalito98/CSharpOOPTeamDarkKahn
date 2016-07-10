namespace Clinic.Models.Speciality
{
    using System.Collections.Generic;
    using Diseases;
    using Interfaces;
    using Common;
    using Validation;
    public class Speciality
    {
        private string name;
        private ICollection<IDoctor> specialityDoctors;
        private ICollection<Disease> specialityDiseases;

        public Speciality(string name)
        {
            this.specialityDiseases = new List<Disease>();
            this.specialityDoctors = new List<IDoctor>();
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                StringValidators.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Speciality name"));
                this.name = value;
            }
        }

        public void AddDoctor(IDoctor newSpecialityDoctor)
        {
            this.specialityDoctors.Add(newSpecialityDoctor);
        }
    }
}