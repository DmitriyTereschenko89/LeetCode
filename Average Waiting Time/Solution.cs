namespace Average_Waiting_Time
{
    internal class Solution
    {
        public double AverageWaitingTime(int[][] customers)
        {
            int n = customers.Length;
            long endTime = customers[0][0] + customers[0][1];
            long waitingTime = endTime - customers[0][0];
            for (int i = 1; i < n; ++i)
            {
                endTime = Math.Max(endTime + customers[i][1], customers[i][0] + customers[i][1]);
                waitingTime += endTime - customers[i][0];
            }

            return waitingTime / (double)n;
        }
    }
}
