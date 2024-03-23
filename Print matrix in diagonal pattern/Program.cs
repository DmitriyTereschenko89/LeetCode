using Print_matrix_in_diagonal_pattern;

int[,] mat = new int[3, 3] {
	{ 1, 2, 3 },
	{ 4, 5, 6 },
	{ 7, 8, 9 }};
int[,] mat1 = new int[2, 2] {
{ 1, 2 },
{ 3, 4 } };
Solution solution = new();
Console.WriteLine(string.Join(", ", solution.MatrixDiagonally(mat)));
Console.WriteLine(string.Join(", ", solution.MatrixDiagonally(mat1)));