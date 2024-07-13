namespace Robot_Collisions
{
    using System.Collections.Generic;

    internal class Solution
    {
        public IList<int> SurvivedRobotsHealths(int[] positions, int[] healths, string directions)
        {
            int n = positions.Length;
            int[] indicies = new int[n];
            for (int index = 0; index < n; ++index)
            {
                indicies[index] = index;
            }

            Array.Sort(indicies, (a, b) => positions[a] - positions[b]);
            List<int> survivedRobots = [];
            Stack<int> st = [];
            foreach (int curIndex in indicies)
            {
                if (directions[curIndex] == 'R')
                {
                    st.Push(curIndex);
                }
                else
                {
                    while (st.Count > 0 && healths[curIndex] > 0)
                    {
                        int topIndex = st.Pop();
                        if (healths[topIndex] > healths[curIndex])
                        {
                            healths[topIndex] -= 1;
                            healths[curIndex] = 0;
                            st.Push(topIndex);
                        }
                        else if (healths[topIndex] < healths[curIndex])
                        {
                            healths[topIndex] = 0;
                            healths[curIndex] -= 1;
                        }
                        else
                        {
                            healths[topIndex] = 0;
                            healths[curIndex] = 0;
                        }
                    }
                }
            }

            for (int i = 0; i < n; ++i)
            {
                if (healths[i] > 0)
                {
                    survivedRobots.Add(healths[i]);
                }
            }

            return survivedRobots;
        }
    }
}
