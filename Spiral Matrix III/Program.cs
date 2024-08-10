using Spiral_Matrix_III;

Solution solution = new();
foreach(var val in solution.SpiralMatrixIII(1, 4, 0, 0))
{
    Console.WriteLine(string.Join(" ", val));
}
Console.WriteLine(new string('=', 20));
foreach(var val in solution.SpiralMatrixIII(5, 6, 1, 4))
{
    Console.WriteLine(string.Join(" ", val));
}
