namespace Sum_of_Digits_of_String_After_Convert
{
    internal class Solution
    {
        private int GetNumSum(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }

            return sum;
        }

        public int GetLucky(string s, int k)
        {
            int sum = 0;
            for (int i = 0; i < s.Length; ++i)
            {
                int num = s[i] - 'a' + 1;
                sum += GetNumSum(num);
            }

            while (k - 1 > 0)
            {
                sum = GetNumSum(sum);
                --k;
            }

            return sum;
        }
    }
}
