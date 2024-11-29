namespace Sliding_Puzzle
{
    public class Solution
    {
        private const int Target = 123450;

        private int Serialize(int[][] grid)
        {
            int state = 0;
            for (int i = 0; i < 2; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    state *= 10;
                    state += grid[i][j];
                }
            }

            return state;
        }

        private int[][] Deserialize(int state)
        {
            int[][] board = new int[2][];
            for (int i = 0; i < 2; ++i)
            {
                board[i] = new int[3];
            }

            for (int i = 1; i >= 0; --i)
            {
                for (int j = 2; j >= 0; --j)
                {
                    int digit = state % 10;
                    state /= 10;
                    board[i][j] = digit;
                }
            }

            return board;
        }

        public int SlidingPuzzle(int[][] board)
        {
            int initialState = Serialize(board);
            if (initialState == Target)
            {
                return 0;
            }

            Dictionary<int, int> statesMap = [];
            Queue<int> moves = [];
            int[] rowDirections = [0, -1, 0, 1];
            int[] colDirections = [-1, 0, 1, 0];
            moves.Enqueue(initialState);
            statesMap.Add(initialState, 0);
            while (moves.Count > 0)
            {
                int currentState = moves.Dequeue();
                int[][] boardState = Deserialize(currentState);
                int row = 0;
                int col = 0;
                for (int r = 0; r < 2; ++r)
                {
                    for (int c = 0; c < 3; ++c)
                    {
                        if (boardState[r][c] == 0)
                        {
                            row = r;
                            col = c;
                            break;
                        }
                    }
                }

                for (int i = 0; i < rowDirections.Length; ++i)
                {
                    int newRow = row + rowDirections[i];
                    int newCol = col + colDirections[i];
                    if (newRow >= 0 && newCol >= 0 && newRow < 2 && newCol < 3)
                    {
                        int[][] currBoard = Deserialize(currentState);
                        (currBoard[newRow][newCol], currBoard[row][col]) = (currBoard[row][col], currBoard[newRow][newCol]);
                        int newState = Serialize(currBoard);
                        if (!statesMap.ContainsKey(newState))
                        {
                            statesMap[newState] = statesMap.GetValueOrDefault(currentState) + 1;
                            moves.Enqueue(newState);
                            if (newState == Target)
                            {
                                return statesMap[newState];
                            }
                        }
                    }
                }
            }

            return -1;
        }
    }
}
