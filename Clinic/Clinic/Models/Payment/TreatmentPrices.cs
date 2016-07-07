namespace ConsoleApplication2.Models.Payment
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    public class TreatmentPrices: ICalculatePrice
    {
        private string diseaseKind;

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
        
        public TreatmentPrices(string diseaseKind)
        {
            this.diseaseKind = diseaseKind;
        }
        public string DiseaseKind { get;private set; }

        public decimal CalculatePrice()
        {
            decimal PriceToPay = 0.0M;
            if (TreatmentPriceList.ContainsKey(diseaseKind))
            {
                PriceToPay += TreatmentPriceList[diseaseKind];
            }
            return PriceToPay;
        }
    }
}
