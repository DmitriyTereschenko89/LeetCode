namespace Find_the_Longest_Substring_Containing_Vowels_in_Even_Counts
{
    internal class Solution
    {
        public int FindTheLongestSubstring(string s)
        {
            Dictionary<char, int> map = new()
            {
                ['a'] = 1,
                ['e'] = 2,
                ['i'] = 4,
                ['o'] = 8,
                ['u'] = 16
            };

            int[] maskIndexes = new int[32];
            int mask = 0;
            Array.Fill(maskIndexes, -1);
            int longestSubstring = 0;
            for (int r = 0; r < s.Length; ++r)
            {
                if (map.TryGetValue(s[r], out int value))
                {
                    mask = mask ^ (1 + value);
                }

                if (maskIndexes[mask] != -1 || mask == 0)
                {
                    longestSubstring = Math.Max(longestSubstring, r - maskIndexes[mask]);
                }
                else
                {
                    maskIndexes[mask] = r;
                }
            }

            return longestSubstring;
        }
    }
}
