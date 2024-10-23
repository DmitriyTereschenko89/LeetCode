namespace Insert_Greatest_Common_Divisors_in_Linked_List
{
    internal class Solution
    {
        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int remainder = a % b;
                a = b;
                b = remainder;
            }

            return a;
        }

        public ListNode InsertGreatestCommonDivisors(ListNode head)
        {
            ListNode cur = head;
            while (cur != null && cur._next != null)
            {
                int gcd = GCD(cur._val, cur._next._val);
                ListNode gcdNode = new(gcd);
                gcdNode._next = cur._next;
                cur._next = gcdNode;
                cur = cur._next._next;
            }

            return head;
        }
    }
}
