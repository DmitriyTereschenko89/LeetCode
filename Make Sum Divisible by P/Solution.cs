namespace Make_Sum_Divisible_by_P
{
    internal class Solution
    {
        public int MinSubarray(int[] nums, int p)
        {
            long total = 0;
            foreach (int num in nums)
            {
                total += num;
            }

            long remainder = total % p;
            if (remainder == 0)
            {
                return 0;
            }

            long curSum = 0;
            int minSize = nums.Length;
            Dictionary<long, int> mp = [];
            mp[0] = -1;
            for (int i = 0; i < nums.Length; ++i)
            {
                curSum = (curSum + nums[i]) % p;
                long prefixSum = (curSum - remainder + p) % p;
                if (mp.ContainsKey(prefixSum))
                {
                    minSize = Math.Min(minSize, i - mp[prefixSum]);
                }

                mp[curSum] = i;
            }

            return minSize == nums.Length ? -1 : minSize;
        }
    }
}
