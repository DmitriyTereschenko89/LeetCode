namespace Different_Ways_to_Add_Parentheses
{
    internal class Solution
    {
        private readonly Dictionary<char, Func<int, int, int>> operators = new()
        {
            ['+'] = (a, b) => a + b,
            ['-'] = (a, b) => a - b,
            ['*'] = (a, b) => a * b
        };

        public IList<int> DiffWaysToCompute(string expression)
        {
            List<int> results = [];
            for (int i = 0; i < expression.Length; i++)
            {
                if (operators.TryGetValue(expression[i], out Func<int, int, int>? operation))
                {
                    var leftPart = DiffWaysToCompute(expression[..i]);
                    var rightPart = DiffWaysToCompute(expression[(i + 1)..]);
                    for (int j = 0; j < leftPart.Count; ++j)
                    {
                        for (int k = 0; k < rightPart.Count; ++k)
                        {
                            results.Add(operation(leftPart[j], rightPart[k]));
                        }
                    }
                }
            }

            if (results.Count == 0)
            {
                results.Add(int.Parse(expression));
            }

            return results;
        }
    }
}
