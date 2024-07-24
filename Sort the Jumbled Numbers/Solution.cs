namespace Sort_the_Jumbled_Numbers
{
    internal class Solution
    {
        private int GetOriginalNum(int num, int[] mapping)
        {
            if (num == 0)
            {
                return mapping[num];
            }

            int originalNum = mapping[num % 10];
            num /= 10;
            int power = 10;
            while (num > 0)
            {
                int lastDigit = num % 10;
                int originalDigit = mapping[lastDigit];
                num /= 10;
                originalNum = originalDigit * power + originalNum;
                power *= 10;
            }

            return originalNum;
        }

        public int[] SortJumbled(int[] mapping, int[] nums)
        {
            int n = nums.Length;
            Num[] candidates = new Num[n];
            for(int i = 0; i < n; ++i)
            {
                candidates[i] = new(nums[i], GetOriginalNum(nums[i], mapping), i);
            }

            Array.Sort(candidates, (a, b) => a.originalNum == b.originalNum ? a.originalIdx - b.originalIdx : a.originalNum - b.originalNum);
            int[] ans = new int[n];
            for (int i = 0; i < n; ++i)
            {
                ans[i] = candidates[i].shuffledNum;
            }

            return ans;
        }
    }
}
