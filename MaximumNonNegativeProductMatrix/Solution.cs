namespace MaximumNonNegativeProductMatrix
{
    internal class Solution
    {
        public int MaxProductPath(int[][] grid)
        {
            int n = grid.Length;
            int m = grid[0].Length;
            int[][] dp = new int[n][];
            for (int r = 0; r < n; ++r)
            {
                dp[r] = new int[m];
            }
            dp[0][0] = grid[0][0];
            for (int c = 1; c < m; ++c)
            {
                dp[0][c] = grid[0][c] * dp[0][c - 1];
            }
            for (int r = 1; r < n; ++r)
            {
                dp[r][0] = grid[r][0] * dp[r - 1][0];
            }
            for (int r = 1; r < n; ++r)
            {
                for (int c = 1; c < m; ++c)
                {
                    int value1 = grid[r][c] * grid[r - 1][c];
                    int value2 = grid[r][c] * grid[r][c - 1];
                    int value3 = dp[r - 1][c] * grid[r][c];
                    int value4 = dp[r][c - 1] * grid[r][c];
                    dp[r][c] = Math.Max(value1, Math.Max(value2, Math.Max(value3, value4)));
                }
            }
            return dp[n - 1][m - 1] < 0 ? -1 : dp[n - 1][m - 1];
        }
    }
}
