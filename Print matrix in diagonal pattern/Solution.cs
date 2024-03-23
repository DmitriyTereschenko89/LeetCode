namespace Print_matrix_in_diagonal_pattern
{
	public class Solution
	{
		private enum Direction
		{
			Right, 
			DiagonalLeft,
			Down,
			Left,
			DiagonalRight
		}

		public List<int> MatrixDiagonally(int[,] mat)
		{
			int n = mat.GetLength(0);
			int[] arr = new int[n * n];
			int idx = 0;

			for (int i = 0; i < n; i++)
			{
				if (i % 2 == 0)
				{
					for (int j = 0, k = i; j <= i; j++, k--)
					{
						arr[idx++] = mat[k,j];
					}
				}
				else
				{
					for (int j = 0, k = i; j <= i; j++, k--)
					{
						arr[idx++] = mat[j,k];
					}
				}
			}

			for (int i = 1; i < n; i++)
			{
				if ((n - i) % 2 == 1)
				{
					for (int r = n - 1, c = i; c < n; c++, r--)
					{
						arr[idx++] = mat[r, c];
					}
				}
				else
				{
					for (int r = n - 1, c = i; c < n; c++, r--)
					{
						arr[idx++] = mat[c, r];
					}
				}
			}
			return [.. arr];
		}
	}
}
