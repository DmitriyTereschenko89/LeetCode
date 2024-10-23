namespace Find_the_Length_of_the_Longest_Common_Prefix
{
    internal class Trie
    {
        private readonly Node _root = new();

        public void Push(int data)
        {
            Node node = _root;
            int digitCount = (int)Math.Log10(data);
            while (digitCount >= 0)
            {
                int power = (int)Math.Pow(10, digitCount);
                int digit = data / power;
                if (node._children[digit] is null)
                {
                    node._children[digit] = new();
                }

                node = node._children[digit];
                data -= digit * power;
                --digitCount;
            }
        }

        public int GetPrefix(int data)
        {
            int prefix = 0;
            Node node = _root;
            int digitCount = (int)Math.Log10(data);
            while (digitCount >= 0)
            {
                int power = (int)Math.Pow(10, digitCount);
                int digit = data / power;
                if (node._children[digit] is null)
                {
                    break;
                }

                node = node._children[digit];
                data -= digit * power;
                --digitCount;
                ++prefix;
            }
            return prefix;
        }
    }
}
