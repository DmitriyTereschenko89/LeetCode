namespace Second_Minimum_Time_to_Reach_Destination
{
    internal class Solution
    {
        public int SecondMinimum(int n, int[][] edges, int time, int change)
        {
            List<int>[] adj = new List<int>[n];
            List<int>[] visitedTimes = new List<int>[n];
            for (int i = 0; i < n; ++i)
            {
                adj[i] = [];
                visitedTimes[i] = [];
            }

            for (int i = 0; i < edges.Length; i++)
            {
                int u = edges[i][0] - 1;
                int v = edges[i][1] - 1;
                adj[u].Add(v);
                adj[v].Add(u);
            }

            int minimum = -1;
            int curTime = 0;
            Queue<int> queue = [];
            
            queue.Enqueue(0);
            while (queue.Count > 0) 
            {
                int queueSize = queue.Count;
                for (int i = 0; i < queueSize; ++i)
                {
                    int node = queue.Dequeue();
                    if (node == n - 1)
                    {
                        if (minimum != -1)
                        {
                            return curTime;
                        }

                        minimum = curTime;
                    }

                    foreach (int neighbor in adj[node])
                    {
                        if (visitedTimes[neighbor].Count == 0 || (visitedTimes[neighbor].Count == 1 && visitedTimes[neighbor][0] != curTime))
                        {
                            visitedTimes[neighbor].Add(curTime);
                            queue.Enqueue(neighbor);
                        }
                    }
                }

                if (curTime / change % 2 != 0)
                {
                    curTime += change - curTime % change;
                }

                curTime += time;
            }

            return minimum;
        }
    }
}
