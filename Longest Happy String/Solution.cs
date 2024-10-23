namespace Longest_Happy_String
{
    using System.Text;

    public class Solution
    {
        private class MaxHeap
        {
            private readonly List<(char, int)> _heap = [];

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

            public (char, int) Pop()
            {
                (_heap[0], _heap[^1]) = (_heap[^1], _heap[0]);
                var removed = _heap[^1];
                _heap.RemoveAt(_heap.Count - 1);
                SiftDown(0, _heap.Count - 1);
                return removed;
            }

            public void Push(char ch, int data)
            {
                _heap.Add((ch, data));
                SiftUp(_heap.Count - 1);
            }

            public int Count()
            {
                return _heap.Count;
            }
        }

        public string LongestDiverseString(int a, int b, int c)
        {
            MaxHeap heap = new();
            StringBuilder str = new();
            if (a > 0)
            {
                heap.Push('a', a);
            }

            if (b > 0)
            {
                heap.Push('b', b);
            }

            if (c > 0)
            {
                heap.Push('c', c);
            }
            
            while (heap.Count() > 1)
            {
                var (one, oneCount) = heap.Pop();
                var (two, twoCount) = heap.Pop();
                if (oneCount >= 2)
                {
                    str.Append(new string(one, 2));
                    oneCount -= 2;
                }
                else
                {
                    str.Append(one);
                    --oneCount;
                }

                if (oneCount > 0)
                {
                    heap.Push(one, oneCount);
                }

                if (twoCount >= 2 && twoCount >= oneCount)
                {
                    str.Append(new string(two, 2));
                    twoCount -= 2;
                }
                else 
                { 
                    str.Append(two);
                    --twoCount;
                }

                if (twoCount > 0)
                {
                    heap.Push(two, twoCount);
                }
            }

            if (heap.Count() == 0)
            {
                return str.ToString();
            }

            var (last, lastCount) = heap.Pop();
            if (str.Length == 0 || str.ToString()[^1] != last)
            {
                if (lastCount >= 2)
                {
                    str.Append(new string(last, 2));
                }
                else if (lastCount > 0)
                {
                    str.Append(last);
                }
            }

            return str.ToString();
        }
    }
}
