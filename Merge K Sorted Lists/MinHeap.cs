namespace Merge_K_Sorted_Lists
{
    public class MinHeap
    {
        private readonly List<ListNode> _heap = [];

        private void SiftDown(int curIdx, int endIdx)
        {
            int childOneIdx = curIdx * 2 + 1;
            while (childOneIdx <= endIdx)
            {
                int swapIdx = childOneIdx;
                int childTwoIdx = curIdx * 2 + 2;
                if (childTwoIdx <= endIdx && _heap[childTwoIdx]._data < _heap[childOneIdx]._data)
                {
                    swapIdx = childTwoIdx;
                }

                if (_heap[swapIdx]._data < _heap[curIdx]._data)
                {
                    (_heap[swapIdx], _heap[curIdx]) = (_heap[curIdx], _heap[swapIdx]);
                    curIdx = swapIdx;
                    childOneIdx = curIdx * 2 + 1;
                }
                else
                {
                    return;
                }
            }
        }

        private void SiftUp(int curIdx)
        {
            int parentIdx = (curIdx - 1) / 2;
            while (parentIdx >= 0 && _heap[parentIdx]._data > _heap[curIdx]._data)
            {
                (_heap[parentIdx], _heap[curIdx]) = (_heap[curIdx], _heap[parentIdx]);
                curIdx = parentIdx;
                parentIdx = (curIdx - 1) / 2;
            }
        }

        public void Push(ListNode node)
        {
            _heap.Add(node);
            SiftUp(_heap.Count - 1);
        }

        public ListNode Pop()
        {
            (_heap[0], _heap[^1]) = (_heap[^1], _heap[0]);
            ListNode removedNode = _heap[^1];
            _heap.RemoveAt(_heap.Count - 1);
            SiftDown(0, _heap.Count - 1);
            return removedNode;
        }

        public bool IsEmpty()
        {
            return _heap.Count == 0;
        }
    }
}