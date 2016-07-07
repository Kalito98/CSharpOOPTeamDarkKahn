﻿namespace ConsoleApplication2.Interfaces
{
    using ConsoleApplication2.Models.Payment;
    using ConsoleApplication2.Models.People;

    public interface IPayments
    {

        Doctor Doctor { get;}

        Patient Patient { get;}

        string Diseases { get;}
    }
}