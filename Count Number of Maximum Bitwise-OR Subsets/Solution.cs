namespace Count_Number_of_Maximum_Bitwise_OR_Subsets
{
    internal class Solution
    {
        public int CountMaxOrSubsets(int[] nums)
        {
            int[] dp = new int[1 << 17];
            int max = 0;
            dp[0] = 1;
            foreach (int num in nums)
            {
                for (int i = max; i >= 0; --i)
                {
                    dp[i | num] += dp[i];
                }

                max |= num;
            }

            return dp[max];
        }
    }
}
