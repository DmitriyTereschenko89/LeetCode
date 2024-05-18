using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreedomTrail
{
    internal class Solution
    {
        private int DFS(int[][] dp, int r, int c, string ring, string key)
        {
            if (c == key.Length)
            {
                return 0;
            }

            if (dp[r][c] != -1)
            {
                return dp[r][c];
            }

            int minSteps = int.MaxValue;
            for (int i = 0; i < ring.Length; ++i)
            {
                if (ring[i] == key[c])
                {
                    int curMinSteps = Math.Min(Math.Abs(i - r), ring.Length - Math.Abs(i - r));
                    minSteps = Math.Min(minSteps, curMinSteps + 1 + DFS(dp, i, c + 1, ring, key));
                }
            }

            dp[r][c] = minSteps;
            return minSteps;
        }

        public int FindRotateSteps(string ring, string key)
        {
            int n = ring.Length;
            int m = key.Length;
            int[][] dp = new int[n][];
            for (int i = 0; i < n; ++i)
            {
                dp[i] = new int[m];
                Array.Fill(dp[i], -1);
            }
            return DFS(dp, 0, 0, ring, key);
        }
    }
}
