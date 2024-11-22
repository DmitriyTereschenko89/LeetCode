namespace Maximum_Sum_of_Distinct_Subarrays_With_Length_K
{
    internal class Solution
    {
        public static long MaximumSubarraySum(int[] nums, int k)
        {
            Dictionary<int, int> map = [];
            long maxSubarraysSum = int.MinValue;
            long curSum = 0;
            for (int i = 0; i < k; ++i)
            {
                map[nums[i]] = map.GetValueOrDefault(nums[i]) + 1;
                curSum += nums[i];
            }

            if (map.Count == k)
            {
                maxSubarraysSum = curSum;
            }

            for (int i = k; i < nums.Length; ++i)
            {
                curSum -= nums[i - k];
                --map[nums[i - k]];
                if (map[nums[i - k]] == 0)
                {
                    map.Remove(nums[i - k]);
                }
                curSum += nums[i];
                map[nums[i]] = map.GetValueOrDefault(nums[i]) + 1;

                if (map.Count == k)
                {
                    maxSubarraysSum = Math.Max(maxSubarraysSum, curSum);
                }
            }

            return maxSubarraysSum == int.MinValue ? 0 : maxSubarraysSum;
        }
    }
}
