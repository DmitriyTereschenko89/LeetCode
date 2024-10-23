namespace Modify_Graph_Edge_Weights
{
    internal class Solution
    {
        private readonly int inf = 1000000009;
        private int AlgorithmDijkstra(List<(int, int)>[] adj, int n, int source, int destination)
        {
            MinHeap heap = new();
            int[] distances = new int[n];
            Array.Fill(distances, inf);
            distances[source] = 0;
            heap.Push(source, 0);
            while (!heap.IsEmpty())
            {
                var (node, distance) = heap.Pop();
                if (distances[node] > distance)
                {
                    continue;
                }

                foreach (var (neighbor, dst) in adj[node])
                {
                    int newDistance = dst + distance;
                    if (newDistance < distances[neighbor])
                    {
                        distances[neighbor] = newDistance;
                        heap.Push(neighbor, newDistance);
                    }
                }
            }

            return distances[destination];
        }

        public int[][] ModifiedGraphEdges(int n, int[][] edges, int source, int destination, int target)
        {
            List<(int, int)>[] adj = new List<(int, int)>[n];
            for (int i = 0; i < n; ++i)
            {
                adj[i] = [];
            }

            foreach(var edge in edges)
            {
                int u = edge[0];
                int v = edge[1];
                int w = edge[2];
                if (w != -1)
                {
                    adj[u].Add((v, w));
                    adj[v].Add((u, w));
                }
            }

            int currentDistance = AlgorithmDijkstra(adj, n, source, destination);
            if (currentDistance < target)
            {
                return [];
            }

            bool mathcesTarget = currentDistance == target;
            foreach (var edge in edges)
            {
                int u = edge[0];
                int v = edge[1];
                int w = edge[2];
                if (w == -1)
                {
                    edge[2] = mathcesTarget ? inf : 1;
                    adj[u].Add((v, edge[2]));
                    adj[v].Add((u, edge[2]));
                    if (!mathcesTarget)
                    {
                        int nextPath = AlgorithmDijkstra(adj, n, source, destination);
                        if (nextPath <= target)
                        {
                            mathcesTarget = true;
                            edge[2] += target - nextPath;
                        }
                    }
                }
            }
            return mathcesTarget ? edges : [];
        }
    }
}
