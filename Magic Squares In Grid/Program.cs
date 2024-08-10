using Magic_Squares_In_Grid;

Solution solution = new();
// 2 7 6
// 1 5 9
// 4 3 8
Console.WriteLine(solution.NumMagicSquaresInside([[2, 7, 6], [1, 5, 9], [4, 3, 8]]));
// 10 3 5
// 1 6 11
// 7 9 2
Console.WriteLine(solution.NumMagicSquaresInside([[10, 3, 5], [1, 6, 11], [7, 9, 2]]));
Console.WriteLine(solution.NumMagicSquaresInside([[4, 3, 8, 4], [9, 5, 1, 9], [2, 7, 6, 2]]));
Console.WriteLine(solution.NumMagicSquaresInside([[8]]));
