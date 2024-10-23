namespace Largest_Number
{
    using System.Text;

    internal class Solution
    {
        public string LargestNumber(int[] nums)
        {
            int n = nums.Length;
            string[] strNums = new string[n];
            for (int i = 0; i < n; ++i)
            {
                strNums[i] = nums[i].ToString();
            }

            Array.Sort(strNums, (a, b) => (b + a).CompareTo(a + b));
            return string.Join("", strNums);
        }
    }
}
