using Lexicographical_Numbers;

Solution solution = new();
Console.WriteLine(string.Join(", ", solution.LexicalOrder(13)));
Console.WriteLine(string.Join(", ", solution.LexicalOrder(2)));
Console.WriteLine(string.Join(", ", solution.LexicalOrder(34)));
Console.WriteLine(string.Join(", ", solution.LexicalOrder(192)));
Console.WriteLine(string.Join(", ", solution.LexicalOrder(50000)));
