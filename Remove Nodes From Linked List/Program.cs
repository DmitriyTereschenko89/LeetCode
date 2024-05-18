using Remove_Nodes_From_Linked_List;

ListNode head = new(5, new(2, new(13, new(3, new(8)))));
ListNode head2 = new(1, new(1, new(1, new(1, new(1)))));
Solution solution = new();
ListNode head1 = solution.RemoveNodes(head);
ListNode head3 = solution.RemoveNodes(head2);
while (head1 != null)
{
    Console.Write(head1._val + " ");
    head1 = head1._next;
}
Console.WriteLine();
while (head3 != null)
{
    Console.Write(head3._val + " ");
    head3 = head3._next;
}
Console.WriteLine();