namespace Path_with_Maximum_Probability
{
    internal class MaxHeap
    {
        private readonly List<(int, double)> _heap = [];

        private void SiftDown(int curIdx, int endIdx)
        {
            int childOneIdx = curIdx * 2 + 1;
            while (childOneIdx <= endIdx)
            {
                int swapIdx = childOneIdx;
                int childTwoIdx = curIdx * 2 + 2;
                if (childTwoIdx <= endIdx && _heap[childTwoIdx].Item2 > _heap[childOneIdx].Item2)
                {
                    swapIdx = childTwoIdx;
                }

                if (_heap[swapIdx].Item2 > _heap[curIdx].Item2)
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
            while (parentIdx >= 0 && _heap[parentIdx].Item2 < _heap[curIdx].Item2)
            {
                (_heap[parentIdx], _heap[curIdx]) = (_heap[curIdx], _heap[parentIdx]);
                curIdx = parentIdx;
                parentIdx = (curIdx - 1) / 2;
            }
        }

        public void Push(int node, double weight)
        {
            _heap.Add((node, weight));
            SiftUp(_heap.Count - 1);
        }

        public (int, double) Pop()
        {
            (_heap[0], _heap[^1]) = (_heap[^1], _heap[0]);
            var removed = _heap[^1];
            _heap.RemoveAt(_heap.Count - 1);
            SiftDown(0, _heap.Count - 1);
            return removed;
        }

        public bool IsEmpty()
        {
            return _heap.Count == 0;
        }
    }
}
