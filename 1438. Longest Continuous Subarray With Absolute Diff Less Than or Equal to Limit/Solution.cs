namespace _1438._Longest_Continuous_Subarray_With_Absolute_Diff_Less_Than_or_Equal_to_Limit
{
    internal class Solution
    {
        /*class Solution {

    public int longestSubarray(int[] nums, int limit) {
        Deque<Integer> maxDeque = new LinkedList<>();
        Deque<Integer> minDeque = new LinkedList<>();
        int left = 0;
        int maxLength = 0;

        for (int right = 0; right < nums.length; ++right) {
            // Maintain the maxDeque in decreasing order
            while (!maxDeque.isEmpty() && maxDeque.peekLast() < nums[right]) {
                maxDeque.pollLast();
            }
            maxDeque.offerLast(nums[right]);

            // Maintain the minDeque in increasing order
            while (!minDeque.isEmpty() && minDeque.peekLast() > nums[right]) {
                minDeque.pollLast();
            }
            minDeque.offerLast(nums[right]);

            // Check if the current window exceeds the limit
            while (maxDeque.peekFirst() - minDeque.peekFirst() > limit) {
                // Remove the elements that are out of the current window
                if (maxDeque.peekFirst() == nums[left]) {
                    maxDeque.pollFirst();
                }
                if (minDeque.peekFirst() == nums[left]) {
                    minDeque.pollFirst();
                }
                ++left;
            }

            maxLength = Math.max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}*/
        public int LongestSubarray(int[] nums, int limit)
        {
            string asn =  "";
            Console.WriteLine(asn.CompareTo(""));
            int a = 0;
            Console.WriteLine(a.CompareTo(0));

            MinHeap minHeap = new();
            MaxHeap maxHeap = new();
            int left = 0;
            int longestSubarray = 1;
            for (int right = 0; right < nums.Length; ++right)
            {
                minHeap.Push(nums[right]);
                maxHeap.Push(nums[right]);
                
                while (left <= right && Math.Abs(minHeap.Peek() - maxHeap.Peek()) > limit)
                {
                    longestSubarray = Math.Max(longestSubarray, right - left + 1);

                    if (minHeap.Peek() == nums[left])
                    {
                        minHeap.Pop();
                    }

                    if (maxHeap.Peek() == nums[left])
                    {
                        maxHeap.Pop();
                    }

                    ++left;
                }

                longestSubarray = Math.Max(longestSubarray, right - left + 1);
            }

            return longestSubarray;
        }
    }
}
