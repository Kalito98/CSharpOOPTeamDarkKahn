namespace Clinic
{
    public class Diseases
    {
        private string diseasesName;

        public Diseases(string diseasesName)
        {
            this.diseasesName= diseasesName;
        }

        public string DiseasesName
        {
            get
            {
                return this.diseasesName;
            }
            private set
            {
                this.diseasesName = value;
            }
        }
    }
}
