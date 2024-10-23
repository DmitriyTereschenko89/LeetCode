namespace The_Number_of_the_Smallest_Unoccupied_Chair
{
    internal class Solution
    {
        private class MinHeap
        {
            private readonly List<int[]> _heap = [];

            private void SiftDown(int curIdx, int endIdx)
            {
                int childOneIdx = curIdx * 2 + 1;
                while (childOneIdx <= endIdx)
                {
                    int swapIdx = childOneIdx;
                    int childTwoIdx = curIdx * 2 + 2;
                    if (childTwoIdx <= endIdx && _heap[childTwoIdx][0] < _heap[childOneIdx][0])
                    {
                        swapIdx = childTwoIdx;
                    }

                    if (_heap[swapIdx][0] < _heap[curIdx][0])
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
                while (parentIdx >= 0 && _heap[parentIdx][0] > _heap[curIdx][0])
                {
                    (_heap[curIdx], _heap[parentIdx]) = (_heap[parentIdx], _heap[curIdx]);
                    curIdx = parentIdx;
                    parentIdx = (curIdx - 1) / 2;
                }
            }

            public void Push(int[] value)
            {
                _heap.Add(value);
                SiftUp(_heap.Count - 1);
            }

            public int[] Pop()
            {
                (_heap[0], _heap[^1]) = (_heap[^1], _heap[0]);
                int[] removed = _heap[^1];
                _heap.RemoveAt(_heap.Count - 1);
                SiftDown(0, _heap.Count - 1);
                return removed;
            }

            public bool IsEmpty()
            {
                return _heap.Count == 0;
            }

            public int Peek()
            {
                return _heap[0][0];
            }
        }

        public int SmallestChair(int[][] times, int targetFriend)
        {
            int n = times.Length;
            (int, int, int)[] arr = new (int, int, int)[n];
            for (int i = 0; i < n; ++i)
            {
                arr[i] = (times[i][0], times[i][1], i);
            }

            Array.Sort(arr, (a, b) => a.Item1 - b.Item1);
            MinHeap usedChairs = new();
            MinHeap availableChairs = new();
            for (int i = 0; i < n; ++i)
            {
                availableChairs.Push([i]);
            }

            foreach (var (arrive, leave, chair) in arr)
            {
                while (!usedChairs.IsEmpty() && usedChairs.Peek() <= arrive)
                {
                    int[] removed = usedChairs.Pop();
                    availableChairs.Push([removed[1]]);
                }

                int[] curChair = availableChairs.Pop();
                usedChairs.Push([leave, curChair[0]]);

                if (chair == targetFriend)
                {
                    return curChair[0];
                }
            }

            return 0;
        }
    }
}
