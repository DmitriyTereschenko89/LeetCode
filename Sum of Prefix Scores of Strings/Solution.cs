namespace Sum_of_Prefix_Scores_of_Strings
{
    internal class Solution
    {
        public int[] SumPrefixScores(string[] words)
        {
            int n = words.Length;
            int[] sumPrefixes = new int[n];
            Trie trie = new();
            for (int i = 0; i < n; ++i)
            {
                trie.Push(words[i]);
            }

            for (int i = 0; i < n; ++i)
            {
                sumPrefixes[i] = trie.Count(words[i]);
            }

            return sumPrefixes;
        }
    }
}
