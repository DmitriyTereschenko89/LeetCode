namespace Path_with_Maximum_Probability
{
    internal class Solution
    {
        private void AlgorithmDijkstra(List<(int, double)>[] adj, double[] distances, int startNode)
        {
            MaxHeap heap = new();
            distances[startNode] = 0;
            heap.Push(startNode, 0);
            while (!heap.IsEmpty())
            {
                var (node, weight) = heap.Pop();
                if (distances[node] == double.MinValue)
                {
                    break;
                }

                foreach (var (neighbor, nextWeight) in adj[node])
                {
                    double curMaxProbabilty = weight == 0 ? 1 * nextWeight : weight * nextWeight;
                    if (curMaxProbabilty > distances[neighbor])
                    {
                        distances[neighbor] = curMaxProbabilty;
                        heap.Push(neighbor, curMaxProbabilty);
                    }
                }
            }
        }

        public double MaxProbability(int n, int[][] edges, double[] succProb, int start_node, int end_node)
        {
            List<(int, double)>[] adj = new List<(int, double)>[n];
            for (int i = 0; i < n; ++i)
            {
                adj[i] = [];
            }

            for (int i = 0; i < edges.Length; ++i)
            {
                int u = edges[i][0];
                int v = edges[i][1];
                double weight = succProb[i];
                adj[u].Add((v, weight));
                adj[v].Add((u, weight));
            }

            double[] distances = new double[n];
            Array.Fill(distances, double.MinValue);
            AlgorithmDijkstra(adj, distances, start_node);

            return distances[end_node] == double.MinValue ? 0 : distances[end_node];
        }
    }
}
