namespace Find_the_City_With_the_Smallest_Number_of_Neighbors_at_a_Threshold_Distance
{
    internal class Solution
    {
        private int AlgorithmDijkstra(List<(int, int)>[] graph, int node, int distanceThreshold)
        {
            MinHeap heap = new();
            HashSet<int> visited = [];
            heap.Push(node, 0);
            while(!heap.IsEmpty())
            {
                var (curNode, distance) = heap.Pop();
                if (visited.Contains(curNode))
                {
                    continue;
                }

                visited.Add(curNode);
                foreach (var (neighbor, dist) in graph[curNode])
                {
                    int newDistance = dist + distance;
                    if (newDistance <= distanceThreshold)
                    {
                        heap.Push(neighbor, newDistance);
                    }
                }
            }

            return visited.Count - 1;
        }

        public int FindTheCity(int n, int[][] edges, int distanceThreshold)
        {
            List<(int, int)>[] graph = new List<(int, int)>[n];
            for (int i = 0; i < n; ++i)
            {
                graph[i] = [];
            }

            for (int i = 0; i < edges.Length; ++i)
            {
                int source = edges[i][0];
                int target = edges[i][1];
                int weight = edges[i][2];
                graph[source].Add((target, weight));
                graph[target].Add((source, weight));
            }

            int neighbors = n;
            int city = -1;
            for (int node = 0; node < n; ++node)
            {
                int curNeighbors = AlgorithmDijkstra(graph, node, distanceThreshold);
                if (curNeighbors <= neighbors)
                {
                    neighbors = curNeighbors;
                    city = node;
                }
            }


            return city;
        }
    }
}

