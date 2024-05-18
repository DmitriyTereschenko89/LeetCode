namespace Merge_K_Sorted_Lists
{
    public class Solution
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            MinHeap minHeap = new();
            ListNode sortedList = new();
            ListNode node = sortedList;
            for(int i = 0; i < lists.Length; ++i)
            {
                if (lists[i] == null)
                {
                    continue;
                }

                minHeap.Push(lists[i]);
            }

            while (!minHeap.IsEmpty())
            {
                ListNode candidate = minHeap.Pop();
                node._next = candidate;
                if (candidate._next != null)
                {
                    minHeap.Push(candidate._next);
                }
                
                node = node._next;
            }

            return sortedList._next;
        }
    }
}
