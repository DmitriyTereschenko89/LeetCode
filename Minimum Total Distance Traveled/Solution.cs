namespace Minimum_Total_Distance_Traveled
{
    internal class Solution
    {
        public long MinimumTotalDistance(IList<int> robot, int[][] factory)
        {
            int n = robot.Count;
            int m = factory.Length;
            long[] dp = new long[n + 1];
            Array.Fill(dp, 907188312128);
            dp[n] = 0;
            List<long> robots = [.. robot];
            robots.Sort();
            Array.Sort(factory, (a, b) => a[0].CompareTo(b[0]));
            for (int j = m - 1; j >= 0; --j)
            {
                for (int i = 0; i < n; ++i)
                {
                    long curTraveled = 0;
                    for (int k = 1; k <= Math.Min(factory[j][1], n - i); ++k)
                    {
                        curTraveled += Math.Abs(robots[i + k - 1] - factory[j][0]);
                        dp[i] = Math.Min(dp[i], dp[i + k] + curTraveled);
                    }
                }
            }

            return dp[0];
        }
    }
}
