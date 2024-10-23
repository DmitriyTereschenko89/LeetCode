namespace K_th_Smallest_in_Lexicographical_Order
{
    internal class Trie
    {
        private readonly Node _root = new();

        private void DFS(Node node, List<int> list, int number)
        {
            for (int num = 0; num < 10; ++num)
            {
                if (node._children[num] != null)
                {
                    list.Add(number + node._children[num]._val);
                    DFS(node._children[num], list, (number + node._children[num]._val) * 10);
                }
            }
        }

        public void Push(int val)
        {
            Node node = _root;
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
            DFS(_root, list, 0);
        }
    }
}
