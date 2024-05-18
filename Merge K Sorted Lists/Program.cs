//[[1,4,5],[1,3,4],[2,6]]
//[1,1,2,3,4,4,5,6]
using Merge_K_Sorted_Lists;

ListNode list1 = new(1, new(4, new(5)));
ListNode list2 = new(1, new(3, new(4)));
ListNode list3 = new(2, new(6));
Solution solution = new();
ListNode sortedList = solution.MergeKLists([list1, list2, list3]);
while (sortedList != null)
{
    Console.Write(sortedList._data + " ");
    sortedList = sortedList._next;
}
Console.WriteLine();