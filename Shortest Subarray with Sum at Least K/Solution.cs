namespace Shortest_Subarray_with_Sum_at_Least_K
{
    internal class Solution
    {
        public static int ShortestSubarray(int[] nums, int k)
        {
            int n = nums.Length;
            int shortestSubarray = int.MaxValue;
            long[] prefixSum = new long[n + 1];
            LinkedList<int> deque = new LinkedList<int>();
            for (int i = 1; i <= n; ++i)
            {
                prefixSum[i] = prefixSum[i - 1] + nums[i - 1];
            }

            for (int i = 0; i <= n; ++i)
            {
                while (deque.Count > 0 && prefixSum[i] - prefixSum[deque.First()] >= k)
                {
                    shortestSubarray = Math.Min(shortestSubarray, i - deque.First());
                    deque.RemoveFirst();
                }

                while (deque.Count > 0 && prefixSum[i] <= prefixSum[deque.Last()])
                {
                    deque.RemoveLast();
                }

                deque.AddLast(i);
            }

            return shortestSubarray == int.MaxValue ? -1 : shortestSubarray;
        }
    }
}
