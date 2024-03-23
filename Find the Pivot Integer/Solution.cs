namespace Find_the_Pivot_Integer
{
	public class Solution
	{
		public int PivotInteger(int n)
		{
			if (n == 1)
			{
				return 1;
			}
			int[] pref = new int[n];
			pref[0] = 1;
			for (int i = 1; i < n; ++i)
			{
				pref[i] = pref[i - 1] + (i + 1);
			}
			for (int i = 1; i < n; ++i)
			{
				if (pref[i - 1] == pref[n - 1] - pref[i])
				{
					return pref[i] - pref[i - 1];
				}
			}
			return -1;
		}
	}
}
