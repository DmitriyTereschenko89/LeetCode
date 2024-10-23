namespace Permutation_in_String
{
    public class Solution
    {
        public bool CheckInclusion(string s1, string s2)
        {
            if (s1.Length > s2.Length)
            {
                return false;
            }

            int[] s1Map = new int[26];
            int[] s2Map = new int[26];
            for (int idx = 0; idx < s1.Length; ++idx)
            {
                ++s1Map[s1[idx] - 'a'];
                ++s2Map[s2[idx] - 'a'];
            }

            int countLetter = 0;
            for (int idx = 0; idx < 26; ++idx)
            {
                if (s1Map[idx] == s2Map[idx])
                {
                    ++countLetter;
                }
            }

            for (int idx = 0; idx < s2.Length - s1.Length; ++idx)
            {
                int left = s2[idx] - 'a';
                int right = s2[idx + s1.Length] - 'a';
                if (countLetter == 26)
                {
                    return true;
                }

                ++s2Map[right];
                if (s2Map[right] == s1Map[right])
                {
                    ++countLetter;
                }
                else if (s2Map[right] == s1Map[right] + 1)
                {
                    --countLetter;
                }

                --s2Map[left];
                if (s2Map[left] == s1Map[left])
                {
                    ++countLetter;
                }
                else if (s2Map[left] == s1Map[left] - 1)
                {
                    --countLetter;
                }
            }

            return countLetter == 26;
        }
    }
}
