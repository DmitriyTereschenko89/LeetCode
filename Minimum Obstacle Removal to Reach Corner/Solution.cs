namespace Minimum_Obstacle_Removal_to_Reach_Corner
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

        private List<(int, int, int)> GetNeighbors(int[][] grid, int r, int c, int rows, int cols)
        {
            int[] deltaX = [0, -1, 0, 1];
            int[] deltaY = [-1, 0, 1, 0];
            List<(int, int, int)> neighbors = [];
            for (int i = 0; i < deltaX.Length; ++i)
            {
                int newR = r + deltaX[i];
                int newC = c + deltaY[i];
                if (newR >= 0 && newR < rows && newC >= 0 && newC < cols)
                {
                    neighbors.Add((newR, newC, grid[newR][newC]));
                }
            }

            return neighbors;
        }

        public int MinimumObstacles(int[][] grid)
        {
            int n = grid.Length;
            int m = grid[0].Length;
            int[][] distances = new int[n][];
            for (int i = 0; i < n; ++i)
            {
                distances[i] = new int[m];
                Array.Fill(distances[i], int.MaxValue);
            }

            distances[0][0] = 0;
            MinHeap minHeap = new();
            minHeap.Push(0, 0, 0);
            while (!minHeap.IsEmpty())
            {
                var (row, col, dst) = minHeap.Pop();
                if (row == n - 1 && col == m - 1)
                {
                    return dst;
                }

                List<(int, int, int)> neighbors = GetNeighbors(grid, row, col, n, m);
                foreach (var neighbor in neighbors)
                {
                    var (neighborRow, neighborCol, neighborDist) = neighbor;
                    int newDistance = dst + neighborDist;
                    if (newDistance < distances[neighborRow][neighborCol])
                    {
                        distances[neighborRow][neighborCol] = newDistance;
                        minHeap.Push(neighborRow, neighborCol, newDistance);
                    }
                }
            }

            return distances[n - 1][m - 1];
        }
    }
}
