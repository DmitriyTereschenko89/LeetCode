namespace IPO
{
    internal class MaxHeapIpo
    {
        private readonly List<Ipo> _heap = [];

        private void SiftDown(int curIdx, int endIdx)
        {
            int childOneIdx = curIdx * 2 + 1;
            while (childOneIdx <= endIdx)
            {
                int swapIdx = childOneIdx;
                int childTwoIdx = childOneIdx * 2 + 2;
                if (childTwoIdx <= endIdx && 
                    (_heap[childTwoIdx]._capital == _heap[childOneIdx]._capital ?
                    _heap[childTwoIdx]._profit > _heap[childOneIdx]._profit:
                    _heap[childTwoIdx]._capital < _heap[childOneIdx]._capital))
                {
                    swapIdx = childTwoIdx;
                }

                if (_heap[swapIdx]._capital == _heap[curIdx]._capital ?
                    _heap[swapIdx]._profit > _heap[curIdx]._profit :
                    _heap[swapIdx]._capital < _heap[curIdx]._capital)
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
            while (parentIdx >= 0 && 
                (_heap[parentIdx]._capital == _heap[curIdx]._capital ?
                _heap[parentIdx]._profit < _heap[curIdx]._profit :
                _heap[parentIdx]._capital > _heap[curIdx]._capital))
            {
                (_heap[parentIdx], _heap[curIdx]) = (_heap[curIdx], _heap[parentIdx]);
                curIdx = parentIdx;
                parentIdx = (curIdx - 1) / 2;
            }
        }

        public bool IsEmpty()
        {
            return _heap.Count == 0;
        }

        public void Push(int capital, int profit)
        {
            _heap.Add(new(capital, profit));
            SiftUp(_heap.Count - 1);
        }

        public Ipo Peek()
        {
            return _heap[0];
        }

        public Ipo Pop()
        {
            (_heap[0], _heap[^1]) = (_heap[^1], _heap[0]);
            Ipo removed = _heap[^1];
            _heap.RemoveAt(_heap.Count - 1);
            SiftDown(0, _heap.Count - 1);
            return removed;
        }
    }
}
