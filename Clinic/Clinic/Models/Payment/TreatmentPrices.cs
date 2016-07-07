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
                {"diseases1", 4},
                {"diseases1", 8},
                {"diseases1", 5},
                {"diseases1", 10},
                {"diseases1", 9},
                {"diseases1", 7},
                {"diseases1", 3},
                {"diseases1", 6},
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
