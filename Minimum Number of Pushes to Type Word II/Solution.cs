namespace Minimum_Number_of_Pushes_to_Type_Word_II
{
    internal class Solution
    {
        public int MinimumPushes(string word)
        {
            int[] freqs = new int[26];
            foreach (char c in word)
            {
                ++freqs[c - 'a'];
            }

            Array.Sort(freqs, (a, b) => b - a);
            int minPushes = 0;
            for (int i = 0; i < 26; ++i)
            {
                int count = freqs[i];
                minPushes += count * (1 + i / 8);
            }

            return minPushes;
        }
    }
}
