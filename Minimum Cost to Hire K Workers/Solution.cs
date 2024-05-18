namespace Minimum_Cost_to_Hire_K_Workers
{
    internal class Solution
    {
        private class MaxHeap
        {
            private readonly List<int> _heap = [];
            
            private void SiftDown(int curIdx, int endIdx)
            {
                int childOneIdx = curIdx * 2 + 1;
                while (childOneIdx <= endIdx) 
                {
                    int swapIdx = childOneIdx;
                    int childTwoIdx = curIdx * 2 + 2;
                    if (childTwoIdx <= endIdx && _heap[childTwoIdx] > _heap[childOneIdx])
                    {
                        swapIdx = childTwoIdx;
                    }

                    if (_heap[swapIdx] > _heap[curIdx])
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
                while (parentIdx >= 0 && _heap[parentIdx] < _heap[curIdx])
                {
                    (_heap[curIdx], _heap[parentIdx]) = (_heap[parentIdx], _heap[curIdx]);
                    curIdx = parentIdx;
                    parentIdx = (curIdx - 1) / 2;
                }
            }

            public void Push(int data)
            {
                _heap.Add(data);
                SiftUp(_heap.Count - 1);
            }

            public int Pop()
            {
                (_heap[0], _heap[^1]) = (_heap[^1], _heap[0]);
                int removed = _heap[^1];
                _heap.RemoveAt(_heap.Count - 1);
                SiftDown(0, _heap.Count - 1);
                return removed;
            }

            public int Count()
            {
                return _heap.Count;
            }

        }

        public double MincostToHireWorkers(int[] quality, int[] wage, int k)
        {
            int n = quality.Length;
            List<(double, int)> workers = [];
            for (int i = 0; i < n; ++i)
            {
                workers.Add((1.0 * wage[i] / quality[i], quality[i]));
            }

            workers.Sort((a, b) => a.Item1.CompareTo(b.Item1));
            MaxHeap _heap = new();
            double totalWorkersCost = int.MaxValue;
            double currentWorkersCost = 0;
            for (int i = 0; i < n; ++i)
            {
                _heap.Push(workers[i].Item2);
                currentWorkersCost += workers[i].Item2;
                if (_heap.Count() > k)
                {
                    currentWorkersCost -= _heap.Pop();
                }
                if (_heap.Count() == k)
                {
                    totalWorkersCost = Math.Min(totalWorkersCost, currentWorkersCost * workers[i].Item1);
                }
            }

            return totalWorkersCost;
        }
    }
}
