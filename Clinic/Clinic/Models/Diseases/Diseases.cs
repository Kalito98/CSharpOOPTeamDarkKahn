namespace Clinic
{
    using System;
    using ConsoleApplication2.People;

    public class Diseases
    {
        private string diseaseCode;
        private string diseasesName;
        public int treatmentTime;  //in minutes
        public decimal treatmentPrice;
        public bool paidByNZOK;
        public GroupDiseases groupDisease;

        public string DiseaseCode
        {
            get { return this.diseaseCode; }
            private set { this.diseaseCode = value; }
        }

        public string DiseasesName
        {
            get { return this.diseasesName; }
            private set { this.diseasesName = value; }
        }

        public int TreatmentTime
        {
            get { return this.treatmentTime; }
            private set { this.treatmentTime = value; }
        }

        public decimal TreatmentPrice
        {
            get { return this.treatmentPrice; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid Price");
                }
                else if (this.paidByNZOK == true)
                {
                    this.treatmentPrice = 0;
                }
                this.treatmentPrice = value;
            }
        }

        public Diseases(string diseaseCode, string diseasesName, int treatmentTime, decimal treatmentPrice,
           bool paidByNZOK, GroupDiseases groupDisease)
        {
            this.diseaseCode = diseaseCode;
            this.diseasesName = diseasesName;
            this.treatmentTime = treatmentTime;
            this.treatmentPrice = treatmentPrice;
            this.paidByNZOK = paidByNZOK;
            this.groupDisease = groupDisease;
        }

    }
}