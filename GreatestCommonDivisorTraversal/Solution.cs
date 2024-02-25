using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisorTraversal
{
	public class Solution
	{
		private class UnionFind
		{
			private readonly int[] parent;
			private readonly int[] size;
			public int count;

			public UnionFind(int n)
			{
				parent = new int[n];
				size = new int[n];
				count = n;
				Array.Fill(size, 1);
				for (int i = 0; i < n; ++i)
				{
					parent[i] = i;
				}
			}

			public int Find(int x)
			{
				if (parent[x] != x)
				{
					parent[x] = Find(parent[x]); 
				}
				return parent[x];
			}

			public bool Union(int x, int y)
			{
				int px = Find(x);
				int py = Find(y);
				if (px == py)
				{
					return false;
				}
				if (size[px] < size[py])
				{
					parent[px] = py;
					size[py] += size[px];
				}
				else
				{
					parent[py] = px;
					size[px] += size[py];
				}
				count -= 1;
				return true;
			}
		}

		public bool CanTraverseAllPairs(int[] nums)
		{
			int n = nums.Length;
			UnionFind uf = new (n);
			Dictionary<int, int> factorIndex = new();
			for (int i = 0; i < n; ++i)
			{
				int f = 2;
				int num = nums[i];
				while (f * f <= num)
				{
					if (num % f == 0)
					{
						if (factorIndex.ContainsKey(f))
						{
							uf.Union(i, factorIndex[f]);
						}
						else
						{
							factorIndex[f] = i;
						}
						while (num % f == 0)
						{
							num /= f;
						}
					}
					++f;
				}
				if (num > 1)
				{
					if (factorIndex.ContainsKey(num))
					{
						uf.Union(i, factorIndex[num]);
					}
					else
					{
						factorIndex[num] = i;
					}
				}
			}
			return uf.count == 1;
		}
	}
}
