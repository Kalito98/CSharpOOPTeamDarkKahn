namespace ConsoleApplication2.Validation
{
    using System;
    public static class EgnValidator
    {
        private static readonly int[] LookUpTable = {2, 4, 8, 5, 10, 9, 7, 3, 6};

        public static bool IsEgnValid(string egn)
        {
            if ( egn.Length != 10 )
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

            var year = int.Parse(egn.Substring(0, 2));
            var month = int.Parse(egn.Substring(2, 2));
            var day = int.Parse(egn.Substring(4, 2));

            if (month > 40)
            {
                month -= 40;
                year += 2000;
            }
            else if (month > 20)
            {
                month -= 20;
                year += 1800;
            }
            else
            {
                year += 1900;
            }
            try
            {
                new DateTime(year, month, day);
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
                sum += (egn[i] - '0') * LookUpTable[i];
            }
            return sum;
        }
    }
}