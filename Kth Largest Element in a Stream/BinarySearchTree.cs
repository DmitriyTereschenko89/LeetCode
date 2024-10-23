namespace Kth_Largest_Element_in_a_Stream
{
    internal class BinarySearchTree
    {
        private Node _root;


        private int FindKthLargest(int k, Node node, NodeInfo nodeInfo)
        {
            if (node._right != null)
            {
                FindKthLargest(k, node._right, nodeInfo);
            }

            if (nodeInfo._visitedNode >= k)
            {
                return nodeInfo._lastValue;
            }

            nodeInfo._visitedNode += 1;
            nodeInfo._lastValue = node._data;
            if (nodeInfo._visitedNode < k)
            {
                if (node._left != null)
                {
                    FindKthLargest(k, node._left, nodeInfo);
                }
            }

            return nodeInfo._lastValue;
        }

        public int FindKthLargest(int k)
        {
            Node node = _root;
            NodeInfo nodeInfo = new();

            return FindKthLargest(k, node, nodeInfo);
        }

        public void Add(int val)
        {
            if (_root is null)
            {
                _root = new(val);
                return;
            }

            Node node = _root;
            while (true)
            {
                if (node._data <= val)
                {
                    if (node._right is null)
                    {
                        node._right = new(val);
                        return;
                    }

                    node = node._right;
                }
                else
                {
                    if (node._left is null)
                    {
                        node._left = new(val);
                        return;
                    }

                    node = node._left;
                }
            }
        }
    }
}
