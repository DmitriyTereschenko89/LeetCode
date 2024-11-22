namespace Count_Unguarded_Cells_in_the_Grid
{
    public class Solution
    {
        private const int Guard = 3;
        private const int Wall = 1;
        private const int Empty = 0;
        private const int CellBeaten = 2;

        private static void BeatCellsByGuard(int[][] grid, int r, int c, int m, int n)
        {
            // beat south direction
            for (int i = r + 1; i < m && grid[i][c] != Guard && grid[i][c] != Wall; ++i)
            {
                grid[i][c] = CellBeaten;
            }

            // beat north direction
            for (int i = r - 1; i >= 0 && grid[i][c] != Guard && grid[i][c] != Wall; --i)
            {
                grid[i][c] = CellBeaten;
            }

            // beat east direction
            for (int i = c + 1; i < n && grid[r][i] != Guard && grid[r][i] != Wall; ++i)
            {
                grid[r][i] = CellBeaten;
            }

            for (int i = c - 1; i >= 0 && grid[r][i] != Guard && grid[r][i] != Wall; --i)
            {
                grid[r][i] = CellBeaten;
            }
        }

        public static int CountUnguarded(int m, int n, int[][] guards, int[][] walls)
        {
            int unguarded = 0;
            int[][] grid = new int[m][];
            for (int i = 0; i < m; ++i)
            {
                grid[i] = new int[n];
            }
            
            foreach (int [] wall in walls)
            {
                grid[wall[0]][wall[1]] = Wall;
            }

            foreach (int[] guard in guards)
            {
                grid[guard[0]][guard[1]] = Guard;                
            }

            for (int r = 0; r < m; ++r)
            {
                for (int c = 0; c < n; ++c)
                {
                    if (grid[r][c] == Guard)
                    {
                        BeatCellsByGuard(grid, r, c, m, n);
                    }
                }
            }

            for (int r = 0; r < m; ++r)
            {
                for (int c = 0; c < n; ++c)
                {
                    if (grid[r][c] == Empty)
                    {
                        ++unguarded;
                    }
                }
            }

            return unguarded;
        }
    }
}
