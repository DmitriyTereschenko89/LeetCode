namespace Minimum_Time_Difference
{
    internal class Solution
    {
        public int FindMinDifference(IList<string> timePoints)
        {
            int n = timePoints.Count;
            int[] times = new int[n];
            for (int i = 0; i < n; ++i)
            {
                int hour = int.Parse(timePoints[i][..2]);
                int minute = int.Parse(timePoints[i][3..]);
                times[i] = hour * 60 + minute;
            }

            Array.Sort(times);
            int minDifference = int.MaxValue;
            for (int i = 1; i < n; ++i)
            {
                minDifference = Math.Min(minDifference, times[i] - times[i - 1]);
            }

            return Math.Min(minDifference, 24 * 60 - times[n - 1] + times[0]);
        }
    }
}
