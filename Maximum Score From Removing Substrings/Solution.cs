namespace Maximum_Score_From_Removing_Substrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Solution
    {
        private int HelperGain(ref string s, string pattern, int profit)
        {
            Stack<char> st = [];
            int totalPoints = 0;
            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] == pattern[1] && st.Count > 0 && st.Peek() == pattern[0])
                {
                    st.Pop();
                    totalPoints += profit;
                }
                else
                {
                    st.Push(s[i]);
                }
            }

            char[] chars = new char[st.Count];
            for (int i = chars.Length - 1; i >= 0; --i)
            {
                chars[i] = st.Pop();
            }

            s = new string(chars);
            return totalPoints;
        }

        public int MaximumGain(string s, int x, int y)
        {
            string[] patterns = ["ab", "ba"];
            int[] profits = [x, y];
            if (x < y)
            {
                (patterns[0], patterns[1]) = (patterns[1], patterns[0]);
                (profits[0], profits[1]) = (profits[1], profits[0]);
            }

            int profit1 = HelperGain(ref s, patterns[0], profits[0]);
            int profit2 = HelperGain(ref s, patterns[1], profits[1]);

            return profit1 + profit2;
        }
    }
}
