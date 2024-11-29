namespace Rotating_the_Box
{
    public class Solution
    {
        private const char Stone = '#';
        private const char Empty = '.';

        private void ShiftStone(char[][] box, int r, int c, int cols)
        {
            int stone = c;
            for (int i = c + 1; i < cols && box[r][i] == Empty; ++i)
            {
                if (box[r][i] == Empty)
                {
                    (box[r][i], box[r][stone]) = (box[r][stone], box[r][i]);
                    ++stone;
                }
            }
        }
        public char[][] RotateTheBox(char[][] box)
        {
            int n = box.Length;
            int m = box[0].Length;

            char[][] rotateBox = new char[m][];
            for (int i = 0; i < m; ++i)
            {
                rotateBox[i] = new char[n];
            }

            for (int r = 0; r < n; ++r)
            {
                for (int c = m - 1; c >= 0; --c)
                {
                    if (box[r][c] == Stone)
                    {
                        ShiftStone(box, r, c, m);
                    }
                }
            }

            int rotateRow = 0;
            for (int r = n - 1; r >= 0; --r)
            {
                int rotateCol = 0;
                for (int c = 0; c < m; ++c)
                {
                    rotateBox[rotateCol++][rotateRow] = box[r][c];
                }

                ++rotateRow;
            }

            

            foreach (char[] row in rotateBox)
            {
                Console.WriteLine(string.Join(", ", row));
            }

            return rotateBox;
        }
    }
}
