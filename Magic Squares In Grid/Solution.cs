namespace Magic_Squares_In_Grid
{
    internal class Solution
    {
        private bool IsDistinct(int[][] grid, int startR, int startC)
        {
            HashSet<int> nums = [];
            for (int r= startR; r < startR + 3; ++r)
            {
                for (int c = startC; c < startC + 3; ++c)
                {
                    if (grid[r][c] >= 1 && grid[r][c] <= 9)
                    {
                        nums.Add(grid[r][c]);
                    }
                }
            }

            return nums.Count == 9;
        }

        private bool IsSameSum(int[][] grid, int startR, int startC)
        {
            int targetSumRow = -1;
            int targetSumCol = -1;
            int diagonalSum1 = grid[startR][startC] + grid[startR + 1][startC + 1] + grid[startR + 2][startC + 2];
            int diagonalSum2 = grid[startR][startC + 2] + grid[startR + 1][startC + 1] + grid[startR + 2][startC];
            for (int r = startR; r < startR + 3; ++r)
            {
                int curSumRow = 0;
                for (int c = startC; c < startC + 3; ++c)
                {
                    curSumRow += grid[r][c];
                }

                if (targetSumRow == -1)
                {
                    targetSumRow = curSumRow;
                }
                else
                {
                    if (targetSumRow != curSumRow)
                    {
                        return false;
                    }
                }
            }

            for (int c = startC; c < startC + 1; ++c)
            {
                int curSumCol = 0;
                for (int r = startR; r < startR + 3; ++r)
                {
                    curSumCol += grid[r][c];
                }

                if (targetSumCol == -1)
                {
                    targetSumCol = curSumCol;
                }
                else
                {
                    if (targetSumCol != curSumCol)
                    {
                        return false;
                    }
                }
            }
            
            return targetSumCol == targetSumRow && targetSumRow == diagonalSum1 && targetSumRow == diagonalSum2;
        }

        public int NumMagicSquaresInside(int[][] grid)
        {
            int magicSquares = 0;
            for (int r = 0; r <= grid.Length - 3; ++r)
            {
                for (int c = 0; c <= grid[r].Length - 3; ++c)
                {
                    if (IsDistinct(grid, r, c) && IsSameSum(grid, r, c))
                    {
                        ++magicSquares;
                    }
                }
            }
            return magicSquares;
        }
    }
}
