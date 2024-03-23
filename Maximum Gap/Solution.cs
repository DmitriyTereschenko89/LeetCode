namespace Maximum_Gap
{
	public class Solution
	{
		public int MaximumGap(int[] nums)
		{
			if (nums.Length < 2)
			{
				return 0;
			}
			RadixSort radixSort = new();
			radixSort.Sort(nums);
			int maxGap = 0;
			for (int i = 1; i < nums.Length; i++)
			{
				maxGap = Math.Max(maxGap, nums[i] - nums[i - 1]);
			}
			return maxGap;
		}
	}
}
