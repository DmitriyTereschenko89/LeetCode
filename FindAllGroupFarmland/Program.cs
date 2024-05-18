using FindAllGroupFarmland;

Solution solution = new();
Print(solution, [[1, 0, 0], [0, 1, 1], [0, 1, 1]]);
Print(solution, [[1, 1], [1, 1]]);
Print(solution, [[0]]);

static void Print(Solution solution, int[][] land)
{
	foreach (var row in solution.FindFarmland(land))
	{
		Console.WriteLine(string.Join(" ", row));
	}
}