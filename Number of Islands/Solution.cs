namespace Number_of_Islands
{
	public class Solution
	{
		private List<(int, int)> GetNeighbors(char[][] grid, int r, int c, int n, int m)
		{
			int[] deltaX = [0, -1, 0, 1];
			int[] deltaY = [-1, 0, 1, 0];
			List<(int, int)> neighbors = [];
			for (int i = 0; i < 4; ++i)
			{
				int nR = deltaX[i] + r;
				int nC = deltaY[i] + c;
				if (nR >= 0 && nR < n && nC >= 0 && nC < m && grid[nR][nC] == '1')
				{
					neighbors.Add((nR, nC));
				}
			}
			return neighbors;
		}

		private void InitIsland(char[][] grid, bool[][] visited, int r, int c, int n, int m)
		{
			Queue<(int, int)> queue = [];
			queue.Enqueue((r, c));
			visited[r][c] = true;
			while (queue.Count > 0)
			{
				var (curR, curC) = queue.Dequeue();
				List<(int, int)> neighbors = GetNeighbors(grid, curR, curC, n, m);
				foreach (var (nR, nC) in neighbors)
				{
					if (!visited[nR][nC])
					{
						visited[nR][nC] = true;
						queue.Enqueue((nR, nC));
					}
				}
			}
		}

		public int NumIslands(char[][] grid)
		{
			int n = grid.Length;
			int m = grid[0].Length;
			bool[][] visited = new bool[n][];
			for (int r = 0; r < n; ++r)
			{
				visited[r] = new bool[m];
			}
			int numIslands = 0;
			for (int r = 0; r < n; ++r)
			{
				for (int c = 0; c < m; ++c)
				{
					if (grid[r][c] == '1' && !visited[r][c])
					{
						++numIslands;
						InitIsland(grid, visited, r, c, n, m);
					}
				}
			}
			return numIslands;
		}
	}
}
