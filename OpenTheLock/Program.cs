using OpenTheLock;

Solution solution = new();
Console.WriteLine(solution.OpenLock(["0201", "0101", "0102", "1212", "2002"], "0202"));
Console.WriteLine(solution.OpenLock(["8888"], "0009"));
Console.WriteLine(solution.OpenLock(["8887", "8889", "8878", "8898", "8788", "8988", "7888", "9888"], "8888"));
Console.WriteLine(solution.OpenLock(["0000"], "8888"));