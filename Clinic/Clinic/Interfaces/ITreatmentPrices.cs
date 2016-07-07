namespace ConsoleApplication2.Interfaces
{
    using ConsoleApplication2.Models.Diseases;

    public interface ITreatmentPrices
    {
        decimal PriceToPay { get; }

        string DiseasesName { get; }

        Diseases Diseases { get; }
    }
}
