namespace Special_Array_With_X_Elements_Greater_Than_or_Equal_X
{
    internal class Solution
    {
        public int SpecialArray(int[] nums)
        {
            Array.Sort(nums, (a, b) => b - a);
            int start = 0;
            int end = nums.Length;
            while (start < end)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] > mid)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid;
                }
            }

            return start < nums.Length && start == nums[start] ? -1 : start;
        }
    }
}
