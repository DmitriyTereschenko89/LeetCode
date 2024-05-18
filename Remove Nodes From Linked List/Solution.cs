namespace Remove_Nodes_From_Linked_List
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

        public ListNode RemoveNodes(ListNode head)
        {
            Stack<ListNode> st = [];
            ListNode reversedHead = ReverseListNode(head);
            ListNode newHead = new(0);
            ListNode node = newHead;
            while (reversedHead != null)
            {
                while (st.Count > 0 && st.Peek()._val <= reversedHead._val)
                {
                    st.Pop();
                }

                if (st.Count == 0)
                {
                    node._next = new(reversedHead._val);
                    node = node._next;
                }

                st.Push(reversedHead);
                reversedHead = reversedHead._next;
            }

            ListNode ans = ReverseListNode(newHead._next);
            return ans;
        }
    }
}
