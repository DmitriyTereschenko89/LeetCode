namespace Design_Circular_Deque
{
    internal class Node(int data = 0, Node prev = null, Node next = null)
    {
        public int data = data;
        public Node prev = prev;
        public Node next = next;
    }
}
