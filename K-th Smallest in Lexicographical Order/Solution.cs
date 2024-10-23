namespace K_th_Smallest_in_Lexicographical_Order
{
    internal class Solution
    {
        private int CountSteps(int n, long prefix1, long prefix2)
        {
            long steps = 0;
            while (prefix1 <= n)
            {
                steps += Math.Min(n + 1, prefix2) - prefix1;
                prefix1 *= 10;
                prefix2 *= 10;
            }

            return (int)steps;
        }

        public int FindKthNumber(int n, int k)
        {
            int curNum = 1;
            --k;
            while (k > 0)
            {
                int steps = CountSteps(n, curNum, curNum + 1);
                if (steps <= k)
                {
                    ++curNum;
                    k -= steps;
                }
                else
                {
                    curNum *= 10;
                    --k;
                }
            }

            return curNum;
        }
    }
}
