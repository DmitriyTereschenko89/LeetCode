namespace Parsing_A_Boolean_Expression
{
    internal class Solution
    {
        public bool ParseBoolExpr(string expression)
        {
            Stack<char> st = [];
            HashSet<char> operators = ['!', '&', '|'];
            foreach (char c in expression)
            {
                if (c == ',' || c == '(')
                {
                    continue;
                }
                else if (c != ')')
                {
                    st.Push(c);
                }
                else
                {
                    bool hasTrue = false;
                    bool hasFalse = false;
                    while (st.Count > 0 && !operators.Contains(st.Peek()))
                    {
                        char topStack = st.Pop();
                        if (topStack == 't')
                        {
                            hasTrue = true;
                        }
                        else if (topStack == 'f')
                        {
                            hasFalse = true;
                        }
                    }

                    char curOperator = st.Pop();
                    if (curOperator == '&')
                    {
                        if (!hasFalse && hasTrue)
                        {
                            st.Push('t');
                        }
                        else
                        {
                            st.Push('f');
                        }
                    }
                    else if (curOperator == '|')
                    {
                        if (hasTrue)
                        {
                            st.Push('t');
                        }
                        else
                        {
                            st.Push('f');
                        }
                    }
                    else
                    {
                        if (hasTrue)
                        {
                            st.Push('f');
                        }
                        else
                        {
                            st.Push('t');
                        }
                    }
                }
            }

            return st.Pop() == 't';
        }
    }
}
