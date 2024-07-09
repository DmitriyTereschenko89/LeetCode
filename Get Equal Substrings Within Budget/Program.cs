using Get_Equal_Substrings_Within_Budget;

Solution solution = new();
Console.WriteLine(solution.EqualSubstring("abcd", "bcdf", 3));
Console.WriteLine(solution.EqualSubstring("abcd", "cdef", 3));
Console.WriteLine(solution.EqualSubstring("abcd", "acde", 0));