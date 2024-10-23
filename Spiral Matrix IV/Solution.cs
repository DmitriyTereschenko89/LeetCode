namespace Spiral_Matrix_IV
{
    internal class Solution
    {
        public int[][] SpiralMatrix(int m, int n, ListNode head)
        {
            int[][] matrix = new int[m][];
            for (int i = 0; i < m; ++i)
            {
                matrix[i] = new int[n];
                Array.Fill(matrix[i], -1);
            }

            int r = 0;
            int endR = m;
            int c = 0;
            int endC = n;
            while (head != null)            
            {
                if (r < endR)
                {
                    for (int i = c; i < endC; ++i)
                    {
                        matrix[r][i] = head is null ? -1 : head._val;
                        head = head?._next;
                    }

                    ++r;
                }
                if (c < endC)
                {
                    for (int i = r; i < endR; ++i)
                    {
                        matrix[i][endC - 1] = head is null ? -1 : head._val;
                        head = head?._next;
                    }

                    --endC;
                }

                if (r < endR)
                {
                    for (int i = endC - 1; i >= c; --i)
                    {
                        matrix[endR - 1][i] = head is null ? -1 : head._val;
                        head = head?._next;
                    }

                    --endR;
                }

                if (c < endC)
                {
                    for (int i = endR - 1; i >= r; --i)
                    {
                        matrix[i][c] = head is null ? -1 : head._val;
                        head = head?._next;
                    }

                    ++c;
                }
            }

            return matrix;
        }
    }
}
