namespace ConsoleApplication2.Validation
{
    public static class EGNValidator
    {
        //TODO: Check date of birth validity
        private static readonly int[] lookUpTable = {2, 4, 8, 5, 10, 9, 7, 3, 6};

        public static bool IsEGNValid(string egn)
        {
            if ( egn.Length != 10)
            {
                return false;
            }
            try
            {
                ulong.Parse(egn);
            }
            catch
            {
                return false;
            }
          

            var remainder = GetSumOfProducts(egn) % 11;
            var controlChar = (remainder < 10) ? remainder : 0;

            return egn[egn.Length - 1] - '0' == controlChar;

        }

        private static int GetSumOfProducts(string egn)
        {
            var sum = 0;

            for (var i = 0; i < 9; i++)
            {
                sum += (egn[i] - '0')*lookUpTable[i];
            }
            return sum;
        }
    }
}