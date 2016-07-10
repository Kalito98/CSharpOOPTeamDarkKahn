namespace Clinic.Models.Common
{
    public static class GlobalErrorMessages
    {
        public const string NullObjectErrorMessage = "Object cannot be null!";
        public const string InvalidStringErrorMessage = "The specified {0} is invalid!";
        public const string StringCannotBeNullOrEmpty = "{0} cannot be null or empty!";
        public const string ObjectCannotBeNull = "{0} cannot be null!";
        public const string InvalidStringLength = "{0} must be between {1} and {2} symbols long!";
        public const string StringTooShortErrorMessage = "{0} must be at least {1} symbols long!";
        public const string NumberLessThanZeroErrorMessage = "{0} cannot be negative!";
    }
}
