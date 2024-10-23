namespace Smallest_Range_Covering_Elements_from_K_Lists
{
    internal class Solution
    {
        private class MinHeap
        {
            private readonly List<(int, int, int)> _heap = [];
            private void SiftUp(int curIdx)
            {
                int parentIdx = (curIdx - 1) / 2;
                while (parentIdx >= 0 && _heap[parentIdx].Item1 > _heap[curIdx].Item1)
                {
                    (_heap[parentIdx], _heap[curIdx]) = (_heap[curIdx], _heap[parentIdx]);
                    curIdx = parentIdx;
                    parentIdx = (curIdx - 1) / 2;
                }
            }

            public void SiftDown(int curIdx, int endIdx)
            {
                int childOneIdx = curIdx * 2 + 1;
                while (childOneIdx <= endIdx)
                {
                    int swapIdx = childOneIdx;
                    int childTwoIdx = curIdx * 2 + 2;
                    if (childTwoIdx <= endIdx && _heap[childTwoIdx].Item1 < _heap[childOneIdx].Item1)
                    {
                        swapIdx = childTwoIdx;
                    }

                    if (_heap[swapIdx].Item1 < _heap[curIdx].Item1)
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

            public bool IsEmpty()
            {
                return _heap.Count == 0;
            }

            public void Push(int num, int kIdx, int idx)
            {
                _heap.Add((num, kIdx, idx));
                SiftUp(_heap.Count - 1);
            }

            public (int, int, int) Pop()
            {
                (_heap[0], _heap[^1]) = (_heap[^1], _heap[0]);
                var removed = _heap[^1];
                _heap.RemoveAt(_heap.Count - 1);
                SiftDown(0, _heap.Count - 1);
                return removed;
            }

            public int Peek()
            {
                return _heap[0].Item1;
            }
        }

        public int[] SmallestRange(IList<IList<int>> nums)
        {
            int k = nums.Count;
            int left = nums[0][0];
            int right = nums[0][0];
            MinHeap heap = new();
            for (int i = 0; i < k; ++i)
            {
                left = Math.Min(left, nums[i][0]);
                right = Math.Max(right, nums[i][0]);
                heap.Push(nums[i][0], i, 0);
            }

            int[] smallestRange = [left, right];
            while (true)
            {
                var (_, kIdx, idx) = heap.Pop();
                ++idx;
                if (idx == nums[kIdx].Count)
                {
                    return smallestRange;
                }

                int nextNum = nums[kIdx][idx];
                heap.Push(nextNum, kIdx, idx);
                left = heap.Peek();
                right = Math.Max(right, nextNum);
                if (right - left < smallestRange[1] - smallestRange[0])
                {
                    smallestRange[0] = left;
                    smallestRange[1] = right;
                }
            }
        }
    }
}
