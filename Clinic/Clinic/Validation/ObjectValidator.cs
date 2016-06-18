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

        public static bool CheckIfPhoneIsValidLandline(string phone)
        {
            
            if ( string.IsNullOrEmpty(phone) )
            {
                return false;
            }
            try
            {   //TODO: Better regex
                //Matches
                //02-343536 | 02/343536 | 066 343536
                //Non - Matches
                //02a343536 | 02+343536
                return Regex.IsMatch(phone,
                      @"^([0-9]*\-?\ ?\/?[0-9]*)$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch ( RegexMatchTimeoutException )
            {
                return false;
            }
        }

        public static bool CheckIfMobilePhoneIsValid(string phone)
        {
            if ( string.IsNullOrEmpty(phone) )
            {
                return false;
            }
            try
            {
                //TODO: Better regex
                //Matches
                //0888123456 0987698652
                //Non - Matches
                //0888 123 456 | 0888-123-456
                return Regex.IsMatch(phone,
                      @"^((088)|(087)|(089)|(098)){1}[0-9]{7}",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch ( RegexMatchTimeoutException )
            {
                return false;
            }
        }
    }
}
