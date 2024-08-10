namespace Minimum_Deletions_to_Make_String_Balanced
{
    using System.Collections.Generic;

    internal class Solution
    {
        public int MinimumDeletions(string s)
        {
            //Stack<char> st = [];
            //int deletions = 0;
            //for (int i = 0; i < s.Length; ++i)
            //{
            //    if (s[i] == 'a' && st.Count > 0 && st.Peek() == 'b')
            //    {
            //        st.Pop();
            //        ++deletions;
            //    }
            //    else
            //    {
            //        st.Push(s[i]);
            //    }
            //}

            //return deletions;
            int n = s.Length;
            int bCount = 0;
            int minDeletions = 0;
            //int[] dp = new int[n + 1];
            for (int i = 0; i < n; ++i)
            {
                if (s[i] == 'b')
                {
                    //dp[i + 1] = dp[i];
                    ++bCount;
                }
                else
                {
                    minDeletions = Math.Min(minDeletions + 1, bCount);  
                    //dp[i + 1] = Math.Min(dp[i] + 1, bCount);
                }
            }

            return minDeletions;
            //return dp[n];
        }
    }
}
