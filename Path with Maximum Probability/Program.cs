using Path_with_Maximum_Probability;

Solution solution = new();
//n = 3, edges = [[0,1]], succProb = [0.5], start = 0, end = 2
//n = 3, edges = [[0,1],[1,2],[0,2]], succProb = [0.5,0.5,0.3], start = 0, end = 2
//n = 3, edges = [[0,1],[1,2],[0,2]], succProb = [0.5,0.5,0.2], start = 0, end = 2
Console.WriteLine(solution.MaxProbability(3, [[0, 1], [1, 2], [0, 2]], [0.5, 0.5, 0.3], 0, 2));
Console.WriteLine(solution.MaxProbability(3, [[0, 1], [1, 2], [0, 2]], [0.5, 0.5, 0.2], 0, 2));
Console.WriteLine(solution.MaxProbability(3, [[0, 1]], [0.5], 0, 2));
Console.WriteLine(solution.MaxProbability(5, [[2, 3], [1, 2], [3, 4], [1, 3], [1, 4], [0, 1], [2, 4], [0, 4], [0, 2]], [0.06, 0.26, 0.49, 0.25, 0.2, 0.64, 0.23, 0.21, 0.77], 0, 3));
