namespace Split_a_String_Into_the_Max_Number_of_Unique_Substrings
{
    internal class Solution
    {
        private int Backtracking(string s, int start, HashSet<string> visited)
        {
            if (start == s.Length)
            {
                return 0;
            }

            int splits = 0;
            for (int end = start + 1; end < s.Length + 1; ++end)
            {
                string candidate = s[start..end];
                if (!visited.Contains(candidate))
                {
                    visited.Add(candidate);
                    splits = Math.Max(splits, 1 + Backtracking(s, end, visited));
                    visited.Remove(candidate);
                }
            }

            return splits;
        }

        public int MaxUniqueSplit(string s)
        {
            return Backtracking(s, 0, []);
        }
    }
}
