namespace ConsoleApplication2.Validation
{
    using System;
    using System.Text.RegularExpressions;

    using Common;

    public static class ObjectValidator
    {
        public static void CheckIfObjectIsNull(object obj, string errorMessage = GlobalConstants.EmptyString)
        {
            if ( obj == null )
            {
                throw new NullReferenceException(GlobalErrorMessages.NullObjectErrorMessage);
            }
        }

        public static bool CheckIfEmailIsValid(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }
            try
            {
                return Regex.IsMatch(email,
                      @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch ( RegexMatchTimeoutException )
            {
                return false;
            }
        }
    }
}
