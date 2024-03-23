using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Zero_Sum_Consecutive_Nodes_from_Linked_List
{
	public class Solution
	{
		public ListNode RemoveZeroSumSublists(ListNode head)
		{
			ListNode front = new(0, head);
			ListNode curr = front;
			int prefixSum = 0;
			Dictionary<int, ListNode> prefSumNode = [];
			while (curr != null)
			{
				prefixSum += curr.val;
				if (prefSumNode.TryGetValue(prefixSum, out ListNode value))
				{
					ListNode prev = value;
					curr = prev.next;
					int p = prefixSum + curr.val;
					while (p != prefixSum)
					{
						prefSumNode.Remove(p);
						curr = curr.next;
						p += curr.val;
					}
					prev.next = curr.next;
				}
				else
				{
					prefSumNode.Add(prefixSum, curr);
				}
				curr = curr.next;
			}
			return front.next;
		}
	}
}
