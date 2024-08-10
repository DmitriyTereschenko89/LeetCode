namespace Filling_Bookcase_Shelves
{
    using System;

    internal class Solution
    {
        public int MinHeightShelves(int[][] books, int shelfWidth)
        {
            int n = books.Length;
            int[] dp = new int[n + 1];
            Array.Fill(dp, int.MaxValue);
            dp[n] = 0;
            for (int i = n - 1; i > -1; --i)
            {
                int curWidth = shelfWidth;
                int maxHeight = 0;
                for (int j = i; j < n; ++j)
                {
                    if (curWidth < books[j][0])
                    {
                        break;
                    }

                    maxHeight = Math.Max(maxHeight, books[j][1]);
                    curWidth -= books[j][0];
                    dp[i] = Math.Min(dp[i], dp[j + 1] + maxHeight);
                }
            }

            return dp[0];
        }
    }
}
