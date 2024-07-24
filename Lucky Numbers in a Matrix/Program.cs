using Lucky_Numbers_in_a_Matrix;

Solution solution = new();

Console.WriteLine(string.Join(", ", solution.LuckyNumbers([[3, 7, 8], [9, 11, 13], [15, 16, 17]])));
Console.WriteLine(string.Join(", ", solution.LuckyNumbers([[1, 10, 4, 2], [9, 3, 8, 7], [15, 16, 17, 12]])));
Console.WriteLine(string.Join(", ", solution.LuckyNumbers([[7, 8], [1, 2]])));
