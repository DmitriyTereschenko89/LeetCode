namespace Minimum_Number_of_Days_to_Disconnect_Island
{
    internal class Solution
    {
        private void BFS(int[][] grid, bool[][] visited, int r, int c)
        {
            int[][] directions = [[0, -1], [-1, 0], [0, 1], [1, 0]];
            Queue<(int, int)> queue = [];
            queue.Enqueue((r, c));
            while (queue.Count > 0)
            {
                var (curR, curC) = queue.Dequeue();
                foreach (var direction in directions)
                {
                    int newR = curR + direction[0];
                    int newC = curC + direction[1];
                    if (newR >= 0 && newR < grid.Length && newC >= 0 && newC < grid[newR].Length && !visited[newR][newC] && grid[newR][newC] == 1)
                    {
                        visited[newR][newC] = true;
                        queue.Enqueue((newR, newC));
                    }
                }
            }
        }

        private int CountIsland(int[][] grid)
        {
            bool[][] visited = new bool[grid.Length][];
            for (int i = 0; i < grid.Length; ++i)
            {
                visited[i] = new bool[grid[i].Length];
            }

            int countIsland = 0;
            for (int r = 0; r < grid.Length; ++r)
            {
                for (int c = 0; c < grid[r].Length; ++c)
                {
                    if (!visited[r][c] && grid[r][c] == 1)
                    {
                        ++countIsland;
                        BFS(grid, visited, r, c);
                    }
                }
            }

            return countIsland;
        }

        public int MinDays(int[][] grid)
        {
            int countIsland = CountIsland(grid);
            if (countIsland != 1)
            {
                return 0;
            }

            for (int r = 0; r < grid.Length; ++r)
            {
                for (int c = 0; c < grid[r].Length; ++c)
                {
                    if (grid[r][c] == 0)
                    {
                        continue;
                    }

                    grid[r][c] = 0;
                    countIsland = CountIsland(grid);
                    if (countIsland != 1)
                    {
                        return 1;
                    }

                    grid[r][c] = 1;
                }
            }

            return 2;
        }
    }
}
