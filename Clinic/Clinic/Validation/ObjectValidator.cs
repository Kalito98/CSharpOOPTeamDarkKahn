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
                //02 492 72 00, 02 4927200, 066 4927200, 02 256 45 56, +359663565656, 359663565656, +359 66 356 56 56, +3592 356 56 56
                //Non - Matches - any non-numeric &
                //0568 659 569, 0878 888 888, +359-888-879-888, 02 256 45 568
                return Regex.IsMatch(phone,
                      @"^\+?(359)?0?(-|\s)?([0-9]{1,2})(-|\s)?([0-9]{3})(-|\s)?(([0-9]{2})(-|\s)?){2}$",
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
                //0888123456, 0987698652, +359-888-859-888, 0888-888888, 0888 888 888, 359 888 888 888, 888-876-888, 0888-876-888, 0878 888 888, 0987888888
                //Non - Matches - any non-numeric &
                //3598888798889856, 0568 659 569, 0233565987, 02 256 45 568
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
