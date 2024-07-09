namespace IPO
{
    internal class Solution
    {
        public int FindMaximizedCapital(int k, int w, int[] profits, int[] capital)
        {
            MaxHeap maxHeap = new();
            MaxHeapIpo maxHeapIpo = new();
            for (int i = 0; i < profits.Length; i++)
            {
                maxHeapIpo.Push(capital[i], profits[i]);
            }

            for (int i = 0; i < k; ++i)
            {
                while (!maxHeapIpo.IsEmpty() && maxHeapIpo.Peek()._capital <= w)
                {
                    maxHeap.Push(maxHeapIpo.Pop()._profit);
                }

                if (maxHeap.IsEmpty())
                {
                    break;
                }

                w += maxHeap.Pop();
            }

            return w;
        }
    }
}
