namespace Find_K_th_Smallest_Pair_Distance
{
    internal class Solution
    {
        private int GetPairs(int[] nums, int diff)
        {
            int left = 0;
            int pairs = 0;
            for (int right = 0; right < nums.Length; ++right)
            {
                while (nums[right] - nums[left] > diff)
                {
                    ++left;
                }

                pairs += right - left;
            }

            return pairs;
        }

        public int SmallestDistancePair(int[] nums, int k)
        {
            Array.Sort(nums);
            int left = 0;
            int right = nums[^1];
            while (left <= right)
            {
                int middle = left + (right - left) / 2;
                int pairs = GetPairs(nums, middle);
                if (pairs >= k)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }

            return left;
        }
    }
}
