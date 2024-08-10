namespace Spiral_Matrix_III
{
    internal class Solution
    {
        public int[][] SpiralMatrixIII(int rows, int cols, int rStart, int cStart)
        {
            int[][] directions = [[0, 1], [1, 0], [0, -1], [-1, 0]];
            int dirIdx = 0;
            int steps = 1;
            int r = rStart;
            int c = cStart;
            List<int[]> matrix = [];
            while (matrix.Count < rows * cols)
            {
                for (int i = 0; i < 2; ++i)
                {
                    for (int j = 0; j < steps; ++j)
                    {
                        if (r >= 0 && r < rows && c >= 0 && c < cols)
                        {
                            matrix.Add([r, c]);
                        }

                        r += directions[dirIdx][0];
                        c += directions[dirIdx][1];
                    }

                    dirIdx = (dirIdx + 1) % 4;
                }

                ++steps;
            }
            return [.. matrix];
        }
    }
}
