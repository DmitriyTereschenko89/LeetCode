namespace Minimum_Time_to_Visit_a_Cell_In_a_Grid
{
    public class Solution
    {
        private class MinHeap
        {
            public readonly List<(int, int, int)> _heap = [];

            private void SiftDown(int curIdx, int endIdx)
            {
                int childOneIdx = curIdx * 2 + 1;
                while (childOneIdx <= endIdx)
                {
                    int swapIdx = childOneIdx;
                    int childTwoIdx = curIdx * 2 + 2;
                    if (childTwoIdx <= endIdx && _heap[childTwoIdx].Item3 < _heap[childOneIdx].Item3)
                    {
                        swapIdx = childTwoIdx;
                    }

                    if (_heap[swapIdx].Item3 < _heap[curIdx].Item3)
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
                while (parentIdx >= 0 && _heap[curIdx].Item3 < _heap[parentIdx].Item3)
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

            public void Push(int row, int col, int dist)
            {
                _heap.Add((row, col, dist));
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
        }

        public int MinimumTime(int[][] grid)
        {
            if (grid[0][1] > 1 && grid[1][0] > 1)
            {
                return -1;
            }

            int n = grid.Length;
            int m = grid[0].Length;
            bool[][] visited = new bool[n][];
            int[] deltaX = [0, -1, 0, 1];
            int[] deltaY = [-1, 0, 1, 0];
            for (int i = 0; i < n; ++i)
            {
                visited[i] = new bool[m];
            }

            MinHeap minHeap = new();
            minHeap.Push(0, 0, grid[0][0]);
            while (!minHeap.IsEmpty())
            {
                var (row, col, time) = minHeap.Pop();
                if (visited[row][col])
                {
                    continue;
                }

                visited[row][col] = true;
                if (row == n - 1 && col == m - 1)
                {
                    return time;
                }

                for (int i = 0; i < deltaX.Length; ++i)
                {
                    int nextR = row + deltaX[i];
                    int nextC = col + deltaY[i];
                    if (nextR >= 0 && nextR < n && nextC >= 0 && nextC < m && !visited[nextR][nextC])
                    {
                        int waitTime = ((grid[nextR][nextC] - time) % 2) == 0 ? 1 : 0;
                        int nextTime = Math.Max(grid[nextR][nextC] + waitTime, time + 1);
                        minHeap.Push(nextR, nextC, nextTime);
                    }
                }
            }

            return -1;
        }
    }
}
