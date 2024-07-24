namespace Find_Valid_Matrix_Given_Row_and_Column_Sums
{
    using System;

    internal class Solution
    {
        public int[][] RestoreMatrix(int[] rowSum, int[] colSum)
        {
            int n = rowSum.Length;
            int m = colSum.Length;
            int[][] restoreMatrix = new int[n][];
            int r;
            for (r = 0; r < n; ++r)
            {
                restoreMatrix[r] = new int[m];
            }

            for (r = 0; r < n; ++r)
            {
                restoreMatrix[r][0] = rowSum[r];
            }

            for (int c = 0; c < m; ++c)
            {
                long curColSum = 0;
                for (r = 0; r < n; ++r)
                {
                    curColSum += restoreMatrix[r][c];
                }

                r = 0;
                while (curColSum > colSum[c])
                {
                    long diff = curColSum - colSum[c];
                    long candidate = Math.Min(diff, restoreMatrix[r][c]);
                    restoreMatrix[r][c] -= (int)candidate;
                    restoreMatrix[r][c + 1] += (int)candidate;
                    curColSum -= candidate;
                    ++r;
                }
            }

            return restoreMatrix;
        }
    }
}
