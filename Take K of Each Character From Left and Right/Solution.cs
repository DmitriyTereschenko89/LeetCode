namespace Take_K_of_Each_Character_From_Left_and_Right
{
    public class Solution
    {
        public static int TakeCharacters(string s, int k)
        {
            Dictionary<char, int> limits = new Dictionary<char, int>
            {
                ['a'] = 0,
                ['b'] = 0,
                ['c'] = 0
            };

            foreach (char c in s)
            {
                ++limits[c];
            }

            foreach (var key in limits.Keys)
            {
                limits[key] -= k;
            }

            foreach (var val in limits.Values)
            {
                if (val < 0)
                {
                    return -1;
                }
            }

            Dictionary<char, int> freqs = new Dictionary<char, int>
            {
                ['a'] = 0,
                ['b'] = 0,
                ['c'] = 0
            };
            int left = 0;
            int characters = 0;
            for (int right = 0; right < s.Length; ++right)
            {
                ++freqs[s[right]];
                while (freqs[s[right]] > limits[s[right]])
                {
                    --freqs[s[left]];
                    ++left;
                }

                characters = Math.Max(characters, right - left + 1);
            }

            return s.Length - characters;
        }
    }
}
