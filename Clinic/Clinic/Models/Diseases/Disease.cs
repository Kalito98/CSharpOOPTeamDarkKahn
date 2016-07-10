namespace Clinic.Models.Diseases
{
    using Common;
    using Validation;
    public class Disease
    {
        private string diseaseCode;
        private string diseasesName;
        public int treatmentTime;  //in minutes
        public decimal treatmentPrice;
        public bool paidByNZOK;
        public GroupDiseases groupDisease;


        public Disease(string diseaseCode, string diseasesName, int treatmentTime, decimal treatmentPrice,
           bool paidByNZOK, GroupDiseases groupDisease)
        {
            this.DiseaseCode = diseaseCode;
            this.DiseasesName = diseasesName;
            this.TreatmentTime = treatmentTime;
            this.TreatmentPrice = treatmentPrice;
            this.paidByNZOK = paidByNZOK;
            this.groupDisease = groupDisease;
        }

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
                ObjectValidator.CheckIfLessThanZero(value, string.Format(GlobalErrorMessages.NumberLessThanZeroErrorMessage, "Treatment price"));
                if (this.paidByNZOK)
                {
                    this.treatmentPrice = 0;
                }
                this.treatmentPrice = value;
            }
        }
    }
}