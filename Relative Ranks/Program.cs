using Relative_Ranks;

Solution solution = new();
Console.WriteLine(string.Join(", ", solution.FindRelativeRanks([5, 4, 3, 2, 1])));
Console.WriteLine(string.Join(", ", solution.FindRelativeRanks([10, 3, 8, 9, 4])));