namespace ConsoleApplication2.Validation
{
    using System.Collections.Generic;

    public static class EGNValidator
    {
        private static readonly Dictionary<int, int> EgnLookUpTable =
            new Dictionary<int, int>
            {
                {1, 2},
                {2, 4},
                {3, 8},
                {4, 5},
                {5, 10},
                {6, 9},
                {7, 7},
                {8, 3},
                {9, 6},
            };

        public static bool IsEGNValid(string egn)
        {
            if ( egn.Length != 10)
            {
                return false;
            }
            try
            {
                uint.Parse(egn);
            }
            catch
            {
                return false;
            }
            var remainder = GetSumOfProducts(egn) / 11;
            var controlChar = (remainder < 10) ? remainder : 0;

            return egn[egn.Length - 1] - '0' == controlChar;

        }

        private static int GetSumOfProducts(string egn)
        {
            var sum = (egn[0] - '0')*EgnLookUpTable[0];

            for (var i = 1; i < egn.Length; i++)
            {
                sum += (egn[i] - '0')*EgnLookUpTable[i];
            }
            return sum;
        }
    }
}