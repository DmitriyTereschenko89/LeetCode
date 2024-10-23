using Insert_Greatest_Common_Divisors_in_Linked_List;

Solution solution = new();
//[18,6,10,3]
ListNode head = new(18, new(6, new(10, new(3))));
ListNode ans = solution.InsertGreatestCommonDivisors(head);
while (ans != null)
{
    Console.Write(ans._val + " ");
    ans = ans._next;
}
Console.WriteLine();
