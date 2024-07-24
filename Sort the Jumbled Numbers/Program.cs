using Sort_the_Jumbled_Numbers;

Solution solution = new();
Console.WriteLine(string.Join(" ", solution.SortJumbled([8, 9, 4, 0, 2, 1, 3, 5, 7, 6], [991, 338, 38])));
Console.WriteLine(string.Join(" ", solution.SortJumbled([0, 1, 2, 3, 4, 5, 6, 7, 8, 9], [789, 456, 123])));
Console.WriteLine(string.Join(" ", solution.SortJumbled([9, 8, 7, 6, 5, 4, 3, 2, 1, 0], [0, 1, 2, 3, 4, 5, 6, 7, 8, 9])));
Console.WriteLine(string.Join(" ", solution.SortJumbled([7, 9, 4, 1, 0, 3, 8, 6, 2, 5], [47799, 19021, 162535, 454, 95, 51890378, 404])));
