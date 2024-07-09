namespace Get_Equal_Substrings_Within_Budget
{
    public class Solution
    {
        public int EqualSubstring(string s, string t, int maxCost)
        {
            int n = s.Length;
            int left = 0;
            int maxSubstring = 0;
            int curCost = 0;
            for (int right = 0; right < n; ++right)
            {
                curCost += Math.Abs(s[right] - t[right]);
                while (curCost > maxCost && left < right)
                {
                    curCost -= Math.Abs(s[left] - t[left]);
                    ++left;
                }

                maxSubstring = Math.Max(maxSubstring, right - left + 1);
            }

            return maxSubstring;
        }
    }
}
