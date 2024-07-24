namespace Lucky_Numbers_in_a_Matrix
{
    using System;
    using System.Collections.Generic;

    internal class Solution
    {
        public IList<int> LuckyNumbers(int[][] matrix)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            HashSet<int> minElems = [];
            for (int r = 0; r < m; ++r)
            {
                int minValue = int.MaxValue;
                for (int c = 0; c < n; ++c)
                {
                    minValue = Math.Min(minValue, matrix[r][c]);
                }

                minElems.Add(minValue);
            }

            List<int> luckyNumbers = [];

            for (int c = 0; c < n; ++c)
            {
                int maxValue = int.MinValue;
                for (int r = 0; r < m; ++r)
                {
                    maxValue = Math.Max(maxValue, matrix[r][c]);
                }

                if (minElems.Contains(maxValue))
                {
                    luckyNumbers.Add(maxValue);
                }
            }

            return luckyNumbers;
        }
    }
}
