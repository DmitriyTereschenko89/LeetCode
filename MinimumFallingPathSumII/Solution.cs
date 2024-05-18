namespace MinimumFallingPathSumII
{
    internal class Solution
    {
        public int MinFallingPathSum(int[][] grid)
        {
            int n = grid.Length;
            int m = grid[0].Length;
            int[] prevDp = (int[])grid[0].Clone();
            for (int r = 1; r < n; ++r)
            {
                int[] dp = new int[m];
                for (int c = 0; c < m; ++c)
                {
                    int minPrevValue = int.MaxValue;
                    for (int i = 0; i < m; ++i)
                    {
                        if (i != c)
                        {
                            minPrevValue = Math.Min(minPrevValue, prevDp[i]);
                        }
                    }
                    dp[c] = minPrevValue + grid[r][c];
                }
                prevDp = dp;
            }
            return prevDp.Min();
        }
    }
}
