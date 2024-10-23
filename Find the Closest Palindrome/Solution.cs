namespace Find_the_Closest_Palindrome
{
    internal class Solution
    {
        private long HalfToPalindrome(long half, bool isEven)
        {
            long newNum = half;
            if (!isEven)
            {
                half /= 10;
            }

            while (half > 0)
            {
                newNum = newNum * 10 + (half % 10);
                half /= 10;
            }

            return newNum;
        }

        public string NearestPalindromic(string n)
        {
            int length = n.Length;
            int i = length % 2 == 0 ? length / 2 - 1 : length / 2;
            long firstHalf = long.Parse(n[..(i + 1)]);
            List<long> candidates = [];
            candidates.Add(HalfToPalindrome(firstHalf, length % 2 == 0));
            candidates.Add(HalfToPalindrome(firstHalf + 1, length % 2 == 0));
            candidates.Add(HalfToPalindrome(firstHalf - 1, length % 2 == 0));
            candidates.Add((long)Math.Pow(10, length - 1) - 1);
            candidates.Add((long)Math.Pow(10, length) + 1);
            long nearistPalindrome = long.MaxValue;
            long curDiff = long.MaxValue;
            long original = long.Parse(n);
            foreach (long candidate in candidates)
            {
                if (candidate == original)
                {
                    continue;
                }

                long diff = Math.Abs(original - candidate);
                if (curDiff >= diff)
                {
                    if (curDiff == diff)
                    {
                        nearistPalindrome = Math.Min(nearistPalindrome, candidate);
                        continue;
                    }

                    curDiff = diff;
                    nearistPalindrome = candidate;
                }
            }

            return nearistPalindrome.ToString();
        }
    }
}
