using System.Runtime.InteropServices;

namespace FindAllGroupFarmland
{
	internal class Solution
	{
		private List<(int, int)> GetNeighbors(int[][] land, int r, int c, int n, int m)
		{
			int[] deltaX = [0, -1, 0, 1];
			int[] deltaY = [-1, 0, 1, 0];
			List<(int, int)> neighbors = [];
			for (int i = 0; i < 4; ++i)
			{
				int nR = deltaX[i] + r;
				int nC = deltaY[i] + c;
				if (nR >= 0 && nR < n && nC >= 0 && nC < m && land[nR][nC] == 1)
				{
					neighbors.Add((nR, nC));
				}
			}
			return neighbors;
		}

		private (int, int) GetBottomRightCoordinate(int[][] land, bool[][] visited, int r, int c, int n, int m)
		{
			int bottomRightR = r;
			int bottomRightC = c;
			Queue<(int, int)> queue = [];
			queue.Enqueue((r, c));
			while (queue.Count > 0)
			{
				var (curR, curC) = queue.Dequeue();
				if (curR > r && curC > c || (curR > r || curC > c))
				{
					bottomRightR = curR;
					bottomRightC = curC;
				}
				List<(int, int)> neighbors = GetNeighbors(land, curR, curC, n, m);
				foreach (var (nr, nc) in neighbors)
				{
					if (!visited[nr][nc])
					{
						visited[nr][nc] = true;
						queue.Enqueue((nr, nc));
					}
				}
			}
			return (bottomRightR, bottomRightC);
		}

		public int[][] FindFarmland(int[][] land)
		{
			int n = land.Length;
			int m = land[0].Length;
			List<int[]> farmlands = [];
			bool[][] visited = new bool[n][];
			for (int r = 0; r < n; ++r)
			{
				visited[r] = new bool[m];
			}
			for (int r = 0; r < n; ++r)
			{
				for (int c = 0; c < m; ++c)
				{
					if (land[r][c] == 1 && !visited[r][c])
					{
						var (bottomRightR, bottomRightC) = GetBottomRightCoordinate(land, visited, r, c, n, m);
						farmlands.Add([r, c, bottomRightR, bottomRightC]);
					}
				}
			}
			return [..farmlands];
		}
	}
}
