namespace Kth_Largest_Element_in_a_Stream
{
    internal class KthLargest
    {
        private readonly BinarySearchTree _bst;
        private readonly int _k;

        public KthLargest(int k, int[] nums)
        {
            _k = k;
            _bst = new();
            foreach (int num in nums)
            {
                _bst.Add(num);
            }
        }

        public int Add(int val)
        {
            _bst.Add(val);
            return _bst.FindKthLargest(_k);
        }
    }
}
