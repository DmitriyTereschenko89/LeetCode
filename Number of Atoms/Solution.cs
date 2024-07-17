namespace Number_of_Atoms
{
    using System.Text;

    internal class Solution
    {
        public string CountOfAtoms(string formula)
        {
            Stack<Dictionary<string, int>> st = [];
            int index = 0;
            int n = formula.Length;
            while (index < n)
            {
                if (formula[index] == '(')
                {
                    st.Push([]);
                }
                else if (formula[index] == ')')
                { 
                    Dictionary<string, int> curMap = st.Pop();
                    int count = 0;
                    while (index + 1 < n && char.IsDigit(formula[index + 1]))
                    {
                        count = count * 10 + (formula[index + 1] - '0');
                        ++index;
                    }

                    if (st.Count == 0)
                    {
                        st.Push([]);
                    }

                    Dictionary<string, int> prevMap = st.Peek();
                    if (count == 0)
                    {
                        count = 1;
                    }

                    foreach (var key in curMap.Keys)
                    {
                        if (prevMap.ContainsKey(key))
                        {
                            prevMap[key] += curMap[key] * count;
                        }
                        else
                        {
                            prevMap[key] = curMap[key] * count;
                        }
                    }
                }
                else
                {
                    string element = formula[index..(index + 1)];
                    if (index + 1 < n && char.IsLower(formula[index + 1]))
                    {
                        element = formula[index..(index + 2)];
                        ++index;
                    }

                    int count = 0;
                    while (index + 1 < n && char.IsDigit(formula[index + 1]))
                    {
                        count = count * 10 + (formula[index + 1] - '0');
                        ++index;
                    }
                    
                    if (st.Count == 0)
                    {
                        st.Push([]);
                    }

                    if (!st.Peek().ContainsKey(element))
                    {
                        st.Peek()[element] = 0;
                    }

                    st.Peek()[element] += count == 0 ? 1 : count;
                }

                ++index;
            }

            StringBuilder ans = new();
            Dictionary<string, int> map = st.Pop();
            List<string> keys = [.. map.Keys];
            keys.Sort();
            foreach (var key in keys)
            {
                ans.Append(key);
                if (map[key] > 1)
                {
                    ans.Append(map[key]);
                }
            }

            return ans.ToString();
        }
    }
}
