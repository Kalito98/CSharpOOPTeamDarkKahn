using ConsoleApplication2.Models.Diseases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Interfaces
{
    interface ITreatmentPrices
    {
        decimal PriceToPay { get; }

        string DiseasesName { get; }

        Diseases Diseases { get; }
    }
}
