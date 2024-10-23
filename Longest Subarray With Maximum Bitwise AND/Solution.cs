namespace Longest_Subarray_With_Maximum_Bitwise_AND
{
    using System;

    internal class Solution
    {
        public int LongestSubarray(int[] nums)
        {
            int maxNum = int.MinValue;
            int maxLength = 1;
            int l = 0;
            for (int r = 0; r < nums.Length; ++r)
            {
                if (maxNum < nums[r])
                {
                    maxNum = nums[r];
                    maxLength = 1;
                    l = r;
                }

                if (maxNum == nums[r])
                {
                    maxLength = Math.Max(maxLength, r - l + 1);
                }
                else
                {
                    l = r + 1;
                }
            }

            return maxLength;
        }
    }
}
