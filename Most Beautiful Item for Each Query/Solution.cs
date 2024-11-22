namespace Most_Beautiful_Item_for_Each_Query
{
    internal class Solution
    {
        private int BinarySearch(int[][] nums, int target)
        {
            int left = 0;
            int right = nums.Length;
            int maxBeauty = int.MinValue;
            while (right - left > 1)
            {
                int middle = (right + left) / 2;
                if (nums[middle][0] <= target)
                {
                    left = middle;
                    maxBeauty = Math.Max(maxBeauty, nums[middle][1]);
                }
                else
                {
                    right = middle;
                }
            }

            maxBeauty = Math.Max(maxBeauty, nums[left][1]);

            return nums[left][0] <= target ? maxBeauty : 0;
        }

        public int[] MaximumBeauty(int[][] items, int[] queries)
        {
            int n = queries.Length;
            Array.Sort(items, (a, b) => a[0].CompareTo(b[0]));
            int maxBeaty = items[0][1];
            for (int i = 0; i < items.Length; ++i)
            {
                maxBeaty = Math.Max(maxBeaty, items[i][1]);
                items[i][1] = maxBeaty;
            }

            int[] maximumBeaty = new int[n];
            for (int i = 0; i < n; ++i)
            {
                maximumBeaty[i] = BinarySearch(items, queries[i]);
            }

            return maximumBeaty;
        }
    }
}
