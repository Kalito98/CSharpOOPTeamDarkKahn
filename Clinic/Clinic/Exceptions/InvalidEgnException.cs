namespace Clinic.Exceptions
{
    using System;

    public class InvalidEgnException : ArgumentException
    {
        public InvalidEgnException()
        {
        }

        public InvalidEgnException(string message) : base(message)
        {
        }
    }
}
