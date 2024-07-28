namespace Minimum_Cost_to_Convert_String_I
{
    internal class Solution
    {
        private long FindPath(List<(int, int)>[] adj, int source, int target)
        {
            MinHeap minHeap = new();
            minHeap.Push(source, 0);
            HashSet<int> visited = [];
            while (!minHeap.IsEmpty())
            {
                var (curNode, curDistance) = minHeap.Pop();
                if (curNode == target)
                {
                    return curDistance;
                }

                if (visited.Contains(curNode))
                {
                    continue;
                }

                visited.Add(curNode);
                foreach (var (node, distance) in adj[curNode])
                {
                    minHeap.Push(node, distance + curDistance);
                }
            }

            return -1;
        }

        public long MinimumCost(string source, string target, char[] original, char[] changed, int[] cost)
        {
            List<(int, int)>[] adj = new List<(int, int)>[26];
            int n = original.Length;
            for (int i = 0; i < 26; ++i)
            {
                adj[i] = [];
            }

            for (int i = 0; i < n; ++i)
            {
                adj[original[i] - 'a'].Add((changed[i] - 'a', cost[i]));
            }

            Dictionary<(char, char), long> pathMap = [];
            long minCost = 0;
            for (int i = 0; i < source.Length; ++i)
            {
                if (source[i] != target[i])
                {
                    if (!pathMap.ContainsKey((source[i], target[i])))
                    {
                        long curPathDistance = FindPath(adj, source[i] - 'a', target[i] - 'a');
                        if (curPathDistance == -1)
                        {
                            return -1;
                        }

                        pathMap[(source[i], target[i])] = curPathDistance;
                    }

                    minCost += pathMap[(source[i], target[i])];
                }
            }

            return minCost;
        }
    }
}
