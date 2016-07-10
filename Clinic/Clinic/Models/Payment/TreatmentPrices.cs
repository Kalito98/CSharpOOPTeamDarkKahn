namespace Clinic.Models.Payment
{
    using System;
    using System.Collections.Generic;

    public static class TreatmentPrices
    {
        private static Dictionary<string, decimal> TreatmentPriceList =
           new Dictionary<String, decimal>
           {
                {"Cavity", 20.00M},
                {"WisdomTooth", 42.13M},
                {"ToothExtraction", 81.00M},
                {"diseases4", 55M},
                {"diseases5", 102M},
                {"diseases6", 99M},
                {"diseases7", 70M},
                {"diseases8", 30M},
                {"diseases9", 156.34M},
           };

        public static decimal CalculatePrice(string diseases)
        {
            decimal PriceToPay = 0.0M;
            if (TreatmentPriceList.ContainsKey(diseases))
            {
                PriceToPay += TreatmentPriceList[diseases];
            }
            return PriceToPay;
        }
    }
}
