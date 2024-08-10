namespace Regions_Cut_By_Slashes
{
    internal class Solution
    {
        private void BFS(int[][] mat, bool[][] visited, int r, int c)
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
                    if (newR >= 0 && newR < mat.Length && newC >= 0 && newC < mat[newR].Length && !visited[newR][newC] && mat[newR][newC] == 0)
                    {
                        visited[newR][newC] = true;
                        queue.Enqueue((newR, newC));
                    }
                }
            }
        }

        public int RegionsBySlashes(string[] grid)
        {
            int rows1 = grid.Length;
            int cols1 = grid[0].Length;
            int rows2 = rows1 * 3;
            int cols2 = cols1 * 3;
            int[][] mat = new int[rows2][];
            bool[][] visited = new bool[rows2][];
            for (int r = 0; r < rows2; ++r)
            {
                mat[r] = new int[cols2];
                visited[r] = new bool[cols2];
            }

            for (int r = 0; r < rows1; ++r)
            {
                for (int c = 0; c < cols1; ++c)
                {
                    int r1 = r * 3;
                    int c1 = c * 3;
                    if (grid[r][c] == '/')
                    {
                        mat[r1][c1 + 2] = 1;
                        mat[r1 + 1][c1 + 1] = 1;
                        mat[r1 + 2][c1] = 1;
                    }
                    else if (grid[r][c] == '\\')
                    {
                        mat[r1][c1] = 1;
                        mat[r1 + 1][c1 + 1] = 1;
                        mat[r1 + 2][c1 + 2] = 1;
                    }

                }
            }

            int regions = 0;
            for (int r = 0; r < mat.Length; ++r)
            {
                for (int c = 0; c < mat[r].Length; ++c)
                {
                    if (mat[r][c] == 0 && !visited[r][c])
                    {
                        BFS(mat, visited, r, c);
                        ++regions;
                    }
                }
            }

            return regions;
        }
    }
}
