namespace Maximum_Number_of_Points_with_Cost
{
    using System;
    using System.Linq;

    internal class Solution
    {
        public long MaxPoints(int[][] points)
        {
            int n = points.Length;
            int m = points[0].Length;
            long[] curRow = new long[m];
            Array.Copy(points[0], curRow, m);
            for (int r = 1; r < n; ++r)
            {
                long[] nextRow = new long[m];
                Array.Copy(points[r], nextRow, m);
                long[] left = new long[m];
                long[] right = new long[m];
                left[0] = curRow[0];
                for (int c = 1; c < m; ++c)
                {
                    left[c] = Math.Max(curRow[c], left[c - 1] - 1);
                }

                right[m - 1] = curRow[m - 1];
                for (int c = m - 2; c >= 0; --c)
                {
                    right[c] = Math.Max(curRow[c], right[c + 1] - 1);
                }

                for (int c = 0; c < m; ++c)
                {
                    nextRow[c] += Math.Max(left[c], right[c]);
                }

                curRow = nextRow;
            }

            return curRow.Max();
        }
    }
}
