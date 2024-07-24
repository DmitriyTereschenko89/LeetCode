using Build_a_Matrix_With_Conditions;

Solution solution = new();
foreach (var row in solution.BuildMatrix(3, [[1, 2], [3, 2]], [[2, 1], [3, 2]]))
{
    Console.WriteLine(string.Join(" ", row));
}

foreach (var row in solution.BuildMatrix(3, [[1, 2], [2, 3], [3, 1], [2, 3]], [[2, 1]]))
{
    Console.WriteLine(string.Join(" ", row));
}

foreach (var row in solution.BuildMatrix(2, [[2, 1], [1, 2]], [[2, 1], [1, 2]]))
{
    Console.WriteLine(string.Join(" ", row));
}
