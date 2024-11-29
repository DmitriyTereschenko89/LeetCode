namespace Shortest_Distance_After_Road_Addition_Queries_I
{
    public class Solution
    {
        private class MinHeap
        {
            public readonly List<(int, int)> _heap = [];

            private void SiftDown(int curIdx, int endIdx)
            {
                int childOneIdx = curIdx * 2 + 1;
                while (childOneIdx <= endIdx)
                {
                    int swapIdx = childOneIdx;
                    int childTwoIdx = curIdx * 2 + 2;
                    if (childTwoIdx <= endIdx && _heap[childTwoIdx].Item2 < _heap[childOneIdx].Item2)
                    {
                        swapIdx = childTwoIdx;
                    }

                    if (_heap[swapIdx].Item2 < _heap[curIdx].Item2)
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
                while (parentIdx >= 0 && _heap[curIdx].Item2 < _heap[parentIdx].Item2)
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

            public void Push(int node, int dist)
            {
                _heap.Add((node, dist));
                SiftUp(_heap.Count - 1);
            }

            public (int, int) Pop()
            {
                (_heap[0], _heap[^1]) = (_heap[^1], _heap[0]);
                var removed = _heap[^1];
                _heap.RemoveAt(_heap.Count - 1);
                SiftDown(0, _heap.Count - 1);
                return removed;
            }
        }

        private int DijkstraAlgorithm(List<(int, int)>[] graph, int start, int nodes)
        {
            int[] distances = new int[nodes];
            Array.Fill(distances, int.MaxValue);
            distances[start] = 0;
            MinHeap minHeap = new();
            minHeap.Push(start, 0);
            while (!minHeap.IsEmpty())
            {
                var (node, dst) = minHeap.Pop();
                if (dst == int.MaxValue)
                {
                    break;
                }

                foreach (var neighbor in graph[node])
                {
                    var (neighborNode, dist) = neighbor;
                    int newDistance = distances[node] + dist;
                    if (newDistance < distances[neighborNode])
                    {
                        distances[neighborNode] = newDistance;
                        minHeap.Push(neighborNode, newDistance);
                    }
                }
            }

            return distances[nodes - 1] == int.MaxValue ? -1 : distances[nodes - 1];
        }

        public int[] ShortestDistanceAfterQueries(int n, int[][] queries)
        {
            List<(int, int)>[] graph = new List<(int, int)>[n];
            for (int i = 0; i < n - 1; ++i)
            {
                graph[i] = [];
                graph[i].Add((i + 1, 1));
            }

            graph[n - 1] = [];
            int queryLength = queries.Length;
            int[] shortestDistances = new int[queryLength];
            for (int i = 0; i < queryLength; ++i)
            {
                int u = queries[i][0];
                int v = queries[i][1];
                graph[u].Add((v, 1));
                shortestDistances[i] = DijkstraAlgorithm(graph, 0, n);
            }

            return shortestDistances;
        }
    }
}
