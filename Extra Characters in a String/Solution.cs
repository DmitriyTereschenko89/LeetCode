namespace Extra_Characters_in_a_String
{
    internal class Solution
    {
        private int DFS(string s, int index, Trie trie, int[] dp)
        {
            if (index == s.Length)
            {
                return 0;
            }

            if (dp[index] != -1)
            {
                return dp[index];
            }

            int minChars = 1 + DFS(s, index + 1, trie, dp);
            Node node = trie._root;
            for (int i = index; i < s.Length; ++i)
            {
                if (node._children[s[i] - 'a'] is null)
                {
                    break;
                }

                node = node._children[s[i] - 'a'];
                if (node._isWord)
                {
                    minChars = Math.Min(minChars, DFS(s, i + 1, trie, dp));
                }
            }

            dp[index] = minChars;
            return minChars;
        }

        public int MinExtraChar(string s, string[] dictionary)
        {
            Trie trie = new();
            foreach (string word in dictionary)
            {
                trie.Push(word);
            }

            int[] dp = new int[s.Length];
            Array.Fill(dp, -1);

            return DFS(s, 0, trie, dp);
        }
    }
}
