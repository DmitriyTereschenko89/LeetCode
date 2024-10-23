using Sum_of_Prefix_Scores_of_Strings;

Solution solution = new();
Console.WriteLine(string.Join(", ", solution.SumPrefixScores(["abc", "ab", "bc", "b"])));
Console.WriteLine(string.Join(", ", solution.SumPrefixScores(["abcd"])));
