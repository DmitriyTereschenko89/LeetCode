namespace Maximum_Swap
{
    internal class Solution
    {
        public int MaximumSwap(int num)
        {
            List<int> digits = [];
            while (num != 0)
            {
                int digit = num % 10;
                digits.Add(digit);
                num /= 10;
            }

            int left = 0;
            int right = digits.Count - 1;
            while (left < right)
            {
                (digits[left], digits[right]) = (digits[right], digits[left]);
                ++left;
                --right;
            }

            int n = digits.Count;
            int maxDigit = -1;
            int rightMaxIdx = -1;
            int maxIdx = -1;
            int leftMinIdx = -1;
            for (int i = n - 1; i >= 0; --i)
            {
                if (maxDigit == -1 || maxDigit < digits[i])
                {
                    maxDigit = digits[i];
                    maxIdx = i;
                    continue;
                }

                if (digits[i] < maxDigit)
                {
                    leftMinIdx = i;
                    rightMaxIdx = maxIdx;
                }
            }

            if (leftMinIdx != -1)
            {
                (digits[leftMinIdx], digits[rightMaxIdx]) = (digits[rightMaxIdx], digits[leftMinIdx]);
            }
            
            int ans = 0;
            for (int i = 0; i < n; ++i)
            {
                ans = ans * 10 + digits[i];
            }

            return ans;
        }
    }
}
