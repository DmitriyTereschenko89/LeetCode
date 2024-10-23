using Convert_1D_Array_Into_2D_Array;

Solution solution = new();
foreach (var row in solution.Construct2DArray([1, 2, 3, 4], 2, 2))
{
    Console.WriteLine(string.Join(" ", row));
}
