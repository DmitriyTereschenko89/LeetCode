using Find_the_Safest_Path_in_a_Grid;

Solution solution = new();
Console.WriteLine(solution.MaximumSafenessFactor([[1, 0, 0], [0, 0, 0], [0, 0, 1]]));
Console.WriteLine(solution.MaximumSafenessFactor([[0, 0, 1], [0, 0, 0], [0, 0, 0]]));
Console.WriteLine(solution.MaximumSafenessFactor([[0, 0, 0, 1], [0, 0, 0, 0], [0, 0, 0, 0], [1, 0, 0, 0]]));
Console.WriteLine(solution.MaximumSafenessFactor([[0, 0, 1], [1, 0, 1], [1, 0, 0]]));