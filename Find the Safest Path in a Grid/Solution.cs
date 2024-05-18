namespace Find_the_Safest_Path_in_a_Grid
{
    internal class Solution
    {
        private class MaxHeap
        {
            private readonly List<(int, int, int)> _heap = [];

            private void SiftDown(int curIdx, int endIdx)
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
                        (_heap[curIdx], _heap[swapIdx]) = (_heap[swapIdx], _heap[curIdx]);
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
                while (parentIdx >= 0 && _heap[parentIdx].Item1 > _heap[curIdx].Item1)
                {
                    (_heap[curIdx], _heap[parentIdx]) = (_heap[parentIdx], _heap[parentIdx]);
                    curIdx = parentIdx;
                    parentIdx = (curIdx - 1) / 2;
                }
            }

            public void Push(int r, int c, int dist)
            {
                _heap.Add((dist, r, c));
                SiftUp(_heap.Count - 1);
            }

            public (int, int, int) Pop()
            {
                (_heap[0], _heap[^1]) = (_heap[^1], _heap[0]);
                (int, int, int) removed = _heap[^1];
                _heap.RemoveAt(_heap.Count - 1);
                SiftDown(0, _heap.Count - 1);
                return removed;
            }

            public int Count()
            {
                return _heap.Count;
            }
        }

        private bool IsBound(int r, int c, int n)
        {
            return Math.Min(r, c) >= 0 && Math.Max(r, c) < n;
        }

        private int[][] Precompute(IList<IList<int>> grid)
        {
            int n = grid.Count;
            int[][] precomputeGrid = new int[n][];
            for (int r = 0; r < n; ++r)
            {
                precomputeGrid[r] = new int[n];
                Array.Fill(precomputeGrid[r], -1);
            }

            Queue<(int, int, int)> queue = [];
            for (int r = 0; r < n; ++r)
            {
                for (int c = 0; c < n; ++c)
                {
                    if (grid[r][c] == 1)
                    {
                        queue.Enqueue((r, c, 0));
                        precomputeGrid[r][c] = 0;
                    }
                }
            }

            while (queue.Count > 0)
            {
                var (r, c, dist) = queue.Dequeue();
                (int, int)[] neighbors = [(r, c - 1), (r - 1, c), (r, c + 1), (r + 1, c)];
                for (int i = 0; i < neighbors.Length; ++i)
                {
                    var (nR, nC) = neighbors[i];
                    if (IsBound(nR, nC, n) && precomputeGrid[nR][nC] == -1)
                    {
                        precomputeGrid[nR][nC] = dist + 1;
                        queue.Enqueue((nR, nC, dist + 1));
                    }
                }
            }

            return precomputeGrid;
        }

        public int MaximumSafenessFactor(IList<IList<int>> grid)
        {
            int n = grid.Count;
            int[][] precomputeGrid = Precompute(grid);
            bool[][] visited = new bool[n][];
            for (int r = 0; r < n; ++r)
            {
                visited[r] = new bool[n];
            }

            MaxHeap heap = new();
            heap.Push(0, 0, precomputeGrid[0][0]);
            visited[0][0] = true;
            while (heap.Count() > 0)
            {
                var (dist, r, c) = heap.Pop();
                if (r == n - 1 && c == n - 1)
                {
                    return dist;
                }
                (int, int)[] neighbors = [(r + 1, c), (r - 1, c), (r, c + 1), (r, c - 1)];
                for (int i = 0; i < neighbors.Length; ++i)
                {
                    var (nR, nC) = neighbors[i];
                    if (IsBound(nR, nC, n) && grid[nR][nC] != 1 && !visited[nR][nC])
                    {
                        visited[nR][nC] = true;
                        int minDist = Math.Min(dist, precomputeGrid[nR][nC]);
                        heap.Push(nR, nC, minDist);
                    }
                }
            }

            return 0;
        }
    }
}
