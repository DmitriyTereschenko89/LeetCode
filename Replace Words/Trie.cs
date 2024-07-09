namespace Replace_Words
{
    internal class Trie
    {
        private readonly Node _root = new();

        public void Push(string word)
        {
            Node node = _root;
            for (int i = 0; i < word.Length; i++)
            {
                if (node._children[word[i] - 'a'] is null)
                {
                    node._children[word[i] - 'a'] = new();
                }

                node = node._children[word[i] - 'a'];
            }

            node._word = word;
        }

        public string FindMaxSubstring(string word)
        {
            Node node = _root;
            int shortestIndex = -1;
            int shortestLength = word.Length;
            for (int i = 0; i < word.Length; ++i)
            {
                if (node._children[word[i] - 'a'] is null)
                {
                    return word[..(shortestIndex + 1)];
                }

                node = node._children[word[i] - 'a'];
                if (!string.IsNullOrEmpty(node._word) && node._word.Length < shortestLength)
                {
                    shortestIndex = i;
                    shortestLength = node._word.Length;
                }
            }

            return word[..(shortestIndex + 1)];
        }
    }
}
