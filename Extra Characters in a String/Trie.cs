namespace Extra_Characters_in_a_String
{
    internal class Trie
    {
        public readonly Node _root = new();

        public void Push(string str)
        {
            Node node = _root;
            for (int i = 0; i < str.Length; ++i)
            {
                if (node._children[str[i] - 'a'] is null)
                {
                    node._children[str[i] - 'a'] = new();
                }

                node = node._children[str[i] - 'a'];
            }

            node._isWord = true;
        }
    }
}
