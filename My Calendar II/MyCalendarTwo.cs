namespace My_Calendar_II
{
    internal class MyCalendarTwo
    {
        private readonly SortedDictionary<int, int> sortedMap;
        private readonly int maxOverlapping;
        public MyCalendarTwo()
        {
            sortedMap = [];
            maxOverlapping = 2;
        }

        public bool Book(int start, int end)
        {
            sortedMap[start] = sortedMap.GetValueOrDefault(start) + 1;
            sortedMap[end] = sortedMap.GetValueOrDefault(end) - 1;
            int currentOverlapping = 0;
            foreach (var pair in sortedMap)
            {
                currentOverlapping += pair.Value;
                if (currentOverlapping > maxOverlapping)
                {
                    sortedMap[start] = sortedMap.GetValueOrDefault(start) - 1;
                    sortedMap[end] = sortedMap.GetValueOrDefault(end) + 1;
                    if (sortedMap[start] == 0)
                    {
                        sortedMap.Remove(start);
                    }

                    return false;
                }
            }

            return true;
        }
    }
}
