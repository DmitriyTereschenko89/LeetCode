namespace Convert_1D_Array_Into_2D_Array
{
    internal class Solution
    {
        public int[][] Construct2DArray(int[] original, int m, int n)
        {
            if (m * n != original.Length)
            {
                return [];
            }

            int r = 0;
            int c = 0;
            int[][] mat = new int[m][];
            for (int i = 0; i < m; ++i)
            {
                mat[i] = new int[n];
            }

            for (int i = 0; i < original.Length; ++i)
            {
                mat[r][c] = original[i];
                ++c;
                if (c == n)
                {
                    ++r;
                    c = 0;
                }
            }

            return mat;
        }
    }
}
