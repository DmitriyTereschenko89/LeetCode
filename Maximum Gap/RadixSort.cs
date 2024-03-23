namespace Maximum_Gap
{
	public class RadixSort
	{
		private void CountingSort(int[] arr, int digit)
		{
			int n = arr.Length;
			int[] count = new int[10];
			int[] sorted = new int[n];
			for (int i = 0; i < n; ++i)
			{
				int colIdx = (int)(arr[i] / Math.Pow(10, digit)) % 10;
				++count[colIdx];
			}
			for (int i = 1; i < 10; ++i)
			{
				count[i] = count[i] + count[i - 1];
			}
			for (int i = n - 1; i >= 0; --i)
			{
				int colIdx = (int)(arr[i] / Math.Pow(10, digit)) % 10;
				--count[colIdx];
				int sortedIdx = count[colIdx];
				sorted[sortedIdx] = arr[i];
			}
			for (int i = 0; i < n; ++i)
			{
				arr[i] = sorted[i];
			}
		}

		public void Sort(int[] arr)
		{
			int maxValue = arr.Max();
			int digit = 0;
			while (maxValue / Math.Pow(10, digit) > 0)
			{
				CountingSort(arr, digit);
				++digit;
			}
		}
	}
}
