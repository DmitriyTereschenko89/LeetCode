namespace Shortest_Palindrome
{
    internal class Solution
    {
        private bool IsPalindrome(string s, int start, int end)
        {
            while (start < end)
            {
                if (s[start] != s[end])
                {
                    return false;
                }

                ++start;
                --end;
            }

            return true;
        }

        public string ShortestPalindrome(string s)
        {
            int n = s.Length;
            for (int i = n - 1; i >= 0; --i)
            {
                if (IsPalindrome(s, 0, i))
                {
                    return new string(s[(i + 1)..].Reverse().ToArray()) + s;
                }
            }

            return string.Empty;
        }
    }
}
