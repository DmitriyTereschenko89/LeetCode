namespace Lexicographical_Numbers
{
    internal class Trie
    {
        private readonly Node root = new();

        private void DFS(Node node, List<int> list, int number)
        {
            for (int digit = 0; digit < 10; ++digit)
            {
                if (node._children[digit] != null)
                {
                    list.Add(number + node._children[digit]._val);
                    int nextNumber = (number + node._children[digit]._val) * 10;
                    DFS(node._children[digit], list, nextNumber);
                }
            }
        }

        public void Push(int val)
        {
            Node node = root;
            int digitCount = (int)Math.Log10(val);
            while (digitCount >= 0)
            {
                int digit = val / (int)Math.Pow(10, digitCount);
                if (node._children[digit] is null)
                {
                    node._children[digit] = new(digit);
                }

                node = node._children[digit];
                val -= digit * (int)Math.Pow(10, digitCount);
                --digitCount;
            }
        }

        public void LexicalOrder(List<int> list)
        {
            Node node = root;
            DFS(node, list, 0);
        }
    }
}
