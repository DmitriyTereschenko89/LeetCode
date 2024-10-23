using Minimum_Time_Difference;

Solution solution = new();
Console.WriteLine(solution.FindMinDifference(["23:59", "00:00"]));
Console.WriteLine(solution.FindMinDifference(["01:01", "02:01"]));
Console.WriteLine(solution.FindMinDifference(["01:01", "02:02"]));
Console.WriteLine(solution.FindMinDifference(["01:01", "02:01", "03:00"]));
Console.WriteLine(solution.FindMinDifference(["00:00", "23:59", "00:00"]));
