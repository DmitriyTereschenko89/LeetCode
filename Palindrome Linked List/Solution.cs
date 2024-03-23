namespace Palindrome_Linked_List
{
	public class Solution
	{
		private (bool, ListNode) DFS(ListNode leftNode, ListNode rightNode)
		{
			if (rightNode is null)
			{
				return (true, leftNode);
			}
			var (outerNodeEqual, comparedLeftNode) = DFS(leftNode, rightNode.next);
			bool nodeEqual = outerNodeEqual && rightNode.val == comparedLeftNode.val;
			return (nodeEqual, comparedLeftNode.next);
		}
		public bool IsPalindrome(ListNode head)
		{
			var (outerNodeEqual, _) = DFS(head, head);
			return outerNodeEqual;
		}
	}
}
