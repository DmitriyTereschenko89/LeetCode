namespace Distinct_Subsequences
{
    internal class Solution
    {
        public int NumDistinct(string s, string t)
        {
            int n = s.Length;
            int m = t.Length;
            int[][] dp = new int[n + 1][];
            for (int i = 0; i <= n; ++i)
            {
                dp[i] = new int[m + 1];
            }

            for (int i = 0; i <= n; ++i)
            {
                dp[i][0] = 1;
            }

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (s[i] == t[j])
                    {
                        dp[i + 1][j + 1] = dp[i][j] + dp[i][j + 1];
                    }
                    else
                    {
                        dp[i + 1][j + 1] = dp[i][j + 1];
                    }
                }
            }

            return dp[n][m];
        }
    }
}
