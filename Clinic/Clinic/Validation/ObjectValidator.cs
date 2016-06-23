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
                //TODO: Find a way to validate international phones
                //Matches
                //0888123456, 0987698652, +359-888-879-888, 0888-888888, 0888 888 888, 359 888 888 888, 888-879-888, 0888-879-888, 0878 888 888, 0987888888
                //Non - Matches
                //3598888798889856, 0568 659 569, 0233565987
                return Regex.IsMatch(phone,
                      @"^(\+?(359)?0?(-|\s)?((88)|(87)|(89)|(98))){1}[0-9]{1}(-|\s)?([0-9]{3}(-|\s)?){2}$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch ( RegexMatchTimeoutException )
            {
                return false;
            }
        }
    }
}
