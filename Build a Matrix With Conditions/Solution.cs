namespace Build_a_Matrix_With_Conditions
{
    internal class Solution
    {
        private bool DFS(bool[] visited, bool[] visiting, List<int>[] adj, List<int> path, int node)
        {
            if (visited[node])
            {
                return false;
            }

            if (visiting[node])
            {
                return true;
            }

            visited[node] = true;
            visiting[node] = true;
            bool isCycle = false;
            foreach(int neighbor in adj[node])
            {
                if (!visited[neighbor])
                {
                    isCycle = DFS(visited, visiting, adj, path, neighbor);
                }

                if (isCycle)
                {
                    return true;
                }
                else if (visiting[neighbor])
                {
                    return true;
                }
            }

            path.Add(node);
            visiting[node] = false;

            return false;
        }

        private List<int> TopologicalSort(int k, List<int>[] adj)
        {
            bool[] visited = new bool[k + 1];
            visited[0] = true;
            bool[] visiting = new bool[k + 1];
            visiting[0] = true;
            
            List<int> path = [];
            for (int node = 1; node <= k; ++node)
            {
                if (!visited[node])
                {
                    if (DFS(visited, visiting, adj, path, node))
                    {
                        return [];
                    }
                }
            }

            return path;
        }

        public int[][] BuildMatrix(int k, int[][] rowConditions, int[][] colConditions)
        {
            List<int>[] rowAdj = new List<int>[k + 1];
            List<int>[] colAdj = new List<int>[k + 1];
            for (int i = 0; i <= k; ++i)
            {
                rowAdj[i] = [];
                colAdj[i] = [];
            }

            foreach (int[] rowCondition in rowConditions)
            {
                int src = rowCondition[0];
                int dst = rowCondition[1];
                rowAdj[dst].Add(src);
            }

            foreach (int[] colCondition in colConditions)
            {
                int src = colCondition[0];
                int dst = colCondition[1];
                colAdj[dst].Add(src);
            }

            List<int> rowPath = TopologicalSort(k, rowAdj);
            List<int> colPath = TopologicalSort(k, colAdj);
            if (rowPath.Count == 0 || colPath.Count == 0)
            {
                return [];
            }

            Dictionary<int, int> map = [];
            for (int i = 0; i < colPath.Count; ++i)
            {
                map[colPath[i]] = i;
            }

            int[][] matrix = new int[k][];
            for (int r = 0; r < k; ++r)
            {
                matrix[r] = new int[k];
            }

            for (int r = 0; r < rowPath.Count; ++r)
            {
                int colIdx = map[rowPath[r]];
                matrix[r][colIdx] = rowPath[r];
            }


            return matrix;
        }
    }
}
