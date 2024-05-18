using Largest_Local_Values_in_a_Matrix;

Solution solution = new();
var maxLocalMatrix = solution.LargestLocal([[9, 9, 8, 1], [5, 6, 2, 6], [8, 2, 6, 4], [6, 2, 2, 2]]);
foreach (var row in maxLocalMatrix)
{
    Console.WriteLine(string.Join(" ", row));
}