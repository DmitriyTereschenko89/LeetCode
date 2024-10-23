namespace Count_Sub_Islands
{
    internal class Solution
    {
        public int CountSubIslands(int[][] grid1, int[][] grid2)
        {
            int n = grid2.Length;
            int m = grid2[0].Length;
            (int, int)[] directions = [(0, -1), (-1, 0), (0, 1), (1, 0)];
            UnionFind uf = new(n * m);
            for (int r = 0; r < n; ++r)
            {
                for (int c = 0; c < m; ++c)
                {
                    if (grid2[r][c] == 1)
                    {
                        foreach (var (row, col) in directions)
                        {
                            int newR = row + r;
                            int newC = col + c;
                            if (newR >= 0 && newR < n && newC >= 0 && newC < m && grid2[newR][newC] == 1)
                            {
                                uf.Union(r * m + c, newR * m + newC);
                            }
                        }
                    }
                }
            }

            bool[] isSubIsland = new bool[n * m];
            Array.Fill(isSubIsland, true);
            for (int r = 0; r < n; ++r)
            {
                for (int c = 0; c < m; ++c)
                {
                    if (grid2[r][c] == 1 && grid1[r][c] != 1)
                    {
                        int root = uf.Find(r * m + c);
                        isSubIsland[root] = false;
                    }
                }
            }

            int countSubIslands = 0;
            for (int r = 0; r < n; ++r)
            {
                for (int c = 0; c < m; ++c)
                {
                    if (grid2[r][c] == 1)
                    {
                        int root = uf.Find(r * m + c);
                        if (isSubIsland[root])
                        {
                            ++countSubIslands;
                            isSubIsland[root] = false;
                        }
                    }
                }
            }

            return countSubIslands;
        }
    }
}
