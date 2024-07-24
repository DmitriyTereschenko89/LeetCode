namespace Sort_the_People
{
    using System;

    internal class Solution
    {
        public string[] SortPeople(string[] names, int[] heights)
        {
            int n = names.Length;
            int[] sortedIndexes = new int[n];
            for (int i = 0; i < n; ++i)
            {
                sortedIndexes[i] = i;
            }

            Array.Sort(sortedIndexes, (a, b) => heights[b] - heights[a]);
            string[] sortPeople = new string[n];
            for (int i = 0; i < n; ++i)
            {
                sortPeople[i] = names[sortedIndexes[i]];
            }

            return sortPeople;
        }
    }
}
