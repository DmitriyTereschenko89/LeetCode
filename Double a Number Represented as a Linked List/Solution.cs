namespace Double_a_Number_Represented_as_a_Linked_List
{
    internal class Solution
    {
        private ListNode ReverseListNode(ListNode head)
        {
            ListNode prev = null;
            ListNode cur = head;
            while (cur != null)
            {
                ListNode next = cur._next;
                cur._next = prev;
                prev = cur;
                cur = next;
            }

            return prev;
        }

        public ListNode DoubleIt(ListNode head)
        {
            ListNode rHead = ReverseListNode(head);
            ListNode node = rHead;
            ListNode mHead = new();
            ListNode mNode = mHead;
            int remainder = 0;
            while (node != null)
            {
                int multiply = node.val * 2 + remainder;
                int data = multiply % 10;
                remainder = multiply / 10;
                mNode._next = new(data);
                mNode = mNode._next;
                node = node._next;
            }

            if (remainder > 0)
            {
                mNode._next = new(remainder);
            }

            return ReverseListNode(mHead._next);
        }
    }
}
