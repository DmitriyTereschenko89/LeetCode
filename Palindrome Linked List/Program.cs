using Palindrome_Linked_List;

int tests = int.Parse(Console.ReadLine());
Solution solution = new();
for (int t = 0; t < tests; t++)
{
	int n = int.Parse(Console.ReadLine());
	string[] nodes = Console.ReadLine().Trim().Split(" ");
	ListNode head = new(0);
	ListNode node = head;
	for (int i = 0; i < n; ++i)
	{
		node.next = new(int.Parse(nodes[i]));
		node = node.next;
	}
    Console.WriteLine(solution.IsPalindrome(head.next));
}