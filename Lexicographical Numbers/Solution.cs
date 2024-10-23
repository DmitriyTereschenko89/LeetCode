namespace Lexicographical_Numbers
{
    internal class Solution
    {
        public IList<int> LexicalOrder(int n)
        {
            List<int> arr = [];
            Trie trie = new();
            for (int num = 1; num <= n; ++num)
            {
                trie.Push(num);
            }

            trie.LexicalOrder(arr);
            return arr;
        }
    }
}
