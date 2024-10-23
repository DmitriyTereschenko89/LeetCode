namespace Lexicographical_Numbers
{
    internal class Node(int val = 0)
    {
        public int _val = val;
        public Node[] _children = new Node[10];
    }
}
