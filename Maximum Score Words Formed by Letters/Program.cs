using Maximum_Score_Words_Formed_by_Letters;

Solution solution = new();
Console.WriteLine(solution.MaxScoreWords(["dog", "cat", "dad", "good"], ['a', 'a', 'c', 'd', 'd', 'd', 'g', 'o', 'o'], [1, 0, 9, 5, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0]));
Console.WriteLine(solution.MaxScoreWords(["xxxz", "ax", "bx", "cx"], ['z','a','b','c','x','x','x'], [4, 4, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 10]));
Console.WriteLine(solution.MaxScoreWords(["leetcode"], ['l','e','t','c','o','d'], [0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0]));