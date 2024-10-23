namespace Number_of_Ways_to_Arrive_at_Destination
{
    internal class Solution
    {
        private void AlgorithmDijkstra(List<(int, int)>[] adj, long[] distances, int[] countPathDp)
        {
            MinHeap heap = new();
            distances[0] = 0;
            countPathDp[0] = 1;
            heap.Push(0, 0);
            while (!heap.IsEmpty())
            {
                var (node, distance) = heap.Pop();
                if (distances[node] == int.MaxValue)
                {
                    continue;
                }

                foreach (var (neighbor, dst) in adj[node])
                {
                    long newDistance = dst + distance;
                    if (newDistance == distances[neighbor])
                    {
                        countPathDp[neighbor] = (countPathDp[neighbor] + countPathDp[node]) % 1000000007;
                    }

                    if (newDistance < distances[neighbor])
                    {
                        countPathDp[neighbor] = countPathDp[node] % 1000000007;
                        distances[neighbor] = newDistance;
                        heap.Push(neighbor, newDistance);
                    }
                }
            }
        }

        public int CountPaths(int n, int[][] roads)
        {
            List<(int, int)>[] adj = new List<(int, int)>[n];
            for (int i = 0; i < n; ++i)
            {
                adj[i] = [];
            }

            foreach (var road in roads)
            {
                int u = road[0];
                int v = road[1];
                int dst = road[2];
                adj[u].Add((v, dst));
                adj[v].Add((u, dst));
            }

            long[] distances = new long[n];
            int[] countPathsDp = new int[n];
            Array.Fill(distances, long.MaxValue);
            AlgorithmDijkstra(adj, distances, countPathsDp);
            return countPathsDp[n - 1];
        }
    }
}
