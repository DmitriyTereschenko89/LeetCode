namespace Palindrome_Partitioning_II
{
    internal class Solution
    {
        public int MinCut(string s)
        {
            int n = s.Length;
            bool[][] dp = new bool[n][];
            int[] dpCut = new int[n];
            for (int i = 0; i < n; ++i)
            {
                dp[i] = new bool[n];
            }

            for (int i = n - 1; i >= 0; --i)
            {
                dpCut[i] = n - i - 1;
                for (int j = i; j < n; ++j)
                {
                    if (s[i] == s[j] && (j - i < 2 || dp[i + 1][j - 1]))
                    {
                        dp[i][j] = true;
                        if (j == n - 1)
                        {
                            dpCut[i] = 0;
                        }
                        else
                        {
                            dpCut[i] = Math.Min(dpCut[i], 1 + dpCut[j + 1]);
                        }
                    }
                }
            }

            return dpCut[0];
        }
    }
}
