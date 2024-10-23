namespace Sum_of_Prefix_Scores_of_Strings
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

                node._children[word[i] - 'a']._count += 1;
                node = node._children[word[i] - 'a'];
            }
        }

        public int Count(string word)
        {
            Node node = _root;
            int count = 0;
            for (int i = 0; i < word.Length; ++i)
            {
                count += node._children[word[i] - 'a']._count;
                node = node._children[word[i] - 'a'];
            }

            return count;
        }
    }
}
