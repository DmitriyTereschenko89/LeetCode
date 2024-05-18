using Double_a_Number_Represented_as_a_Linked_List;

Solution solution = new(); 
ListNode head1 = new(1, new(8, new(9)));
ListNode head2 = new(9, new(9, new(9)));
ListNode mHead1 = solution.DoubleIt(head1);
ListNode mHead2 = solution.DoubleIt(head2);
while (mHead1 != null)
{
    Console.Write(mHead1._val + " ");
    mHead1 = mHead1._next;
}
Console.WriteLine();
while (mHead2 != null)
{
    Console.Write(mHead2._val + " ");
    mHead2 = mHead2._next;
}
Console.WriteLine();
Console.WriteLine();