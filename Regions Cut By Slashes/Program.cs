using Regions_Cut_By_Slashes;

Solution solution = new();
Console.WriteLine(solution.RegionsBySlashes([" /", "/ "]));
Console.WriteLine(solution.RegionsBySlashes([" /", "  "]));
Console.WriteLine(solution.RegionsBySlashes(["/\\", "\\/"]));
