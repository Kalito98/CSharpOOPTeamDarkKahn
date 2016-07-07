namespace ConsoleApplication2.Models.Payment
{
    using Common;
    using ConsoleApplication2.Models.Diseases;
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using Validation;

    public class TreatmentPrices : ICalculatePrice,ITreatmentPrices
    {

        private decimal priceToPay;
        private string diseasesName;

        public Diseases Diseases { get; }

        private static readonly Dictionary<string, int> TreatmentPriceList =
           new Dictionary<String, int>
           {
                {"diseases1", 2},
                {"diseases2", 4},
                {"diseases3", 8},
                {"diseases4", 5},
                {"diseases5", 10},
                {"diseases6", 9},
                {"diseases7", 7},
                {"diseases8", 3},
                {"diseases9", 6},
           };

        //ToDO need info from diseases

        public TreatmentPrices(decimal priceToPay )
        {
            this.priceToPay = priceToPay;
            this.DiseasesName = diseasesName;
        }

        public string DiseasesName
        {
            get { return this.diseasesName = Diseases.DiseasesName; }
            set
            {
                StringValidators.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, this.GetType().Name));
                this.diseasesName = value;
            }
        }

        public decimal PriceToPay
        {
            get { return this.priceToPay; }
            set
            {
                StringValidators.CheckIfNull(value, String.Format(GlobalErrorMessages.ObjectCannotBeNull, this.GetType().Name));
                this.priceToPay = value;
            }
        }

        public decimal CalculatePrice()
        {
            decimal PriceToPay = 0.0M;
            if (TreatmentPriceList.ContainsKey(diseasesName))
            {
                PriceToPay += TreatmentPriceList[diseasesName];
            }
            return PriceToPay;
        }
    }
}
