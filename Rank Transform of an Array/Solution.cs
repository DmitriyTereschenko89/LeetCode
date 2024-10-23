namespace Rank_Transform_of_an_Array
{
    internal class Solution
    {
        //[100,100,100], [40,10,20,30]
        public int[] ArrayRankTransform(int[] arr)
        {
            int n = arr.Length;
            Dictionary<int, List<int>> map = [];
            for (int i = 0; i < n; ++i)
            {
                if (!map.ContainsKey(arr[i]))
                {
                    map.Add(arr[i], []);
                }

                map[arr[i]].Add(i);
            }

            Array.Sort(arr);
            int rank = 1;
            int[] ans = new int[n];
            for (int i = 0; i < n; ++i)
            {
                if (map.TryGetValue(arr[i], out var indexes))
                {
                    foreach (var idx in indexes)
                    {
                        ans[idx] = rank;
                    }

                    ++rank;
                    map.Remove(arr[i]);
                }
            }

            return ans;
        }
    }
}
