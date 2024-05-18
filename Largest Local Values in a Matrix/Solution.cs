namespace Largest_Local_Values_in_a_Matrix
{
    internal class Solution
    {
        public int[][] LargestLocal(int[][] grid)
        {
            int n = grid.Length;
            int[][] maxLocal = new int[n - 2][];
            for (int i = 0; i < n - 2; ++i)
            {
                maxLocal[i] = new int[n - 2];
            }

            for (int r = 0; r < n - 2; ++r)
            {
                for (int c = 0; c < n - 2; ++c)
                {
                    int curMaxLocal = int.MinValue;
                    for (int i = r; i < r + 3; ++i)
                    {
                        for (int j = c; j < c + 3; ++j)
                        {
                            curMaxLocal = Math.Max(curMaxLocal, grid[i][j]);
                        }
                    }

                    maxLocal[r][c] = curMaxLocal;
                }
            }

            return maxLocal;
        }
    }
}
