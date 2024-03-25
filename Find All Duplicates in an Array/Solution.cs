namespace Find_All_Duplicates_in_an_Array
{
	public class Solution
	{
		public IList<int> FindDuplicates(int[] nums)
		{
			List<int> ans = [];
			for (int i = 0; i < nums.Length; ++i)
			{
				int num = Math.Abs(nums[i]);
				if (nums[num - 1] < 0)
				{
					ans.Add(num);
					continue;
				}
				nums[num - 1] *= -1;
			}
			return ans;
		}
	}
}
