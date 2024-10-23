using Walking_Robot_Simulation;

Solution solution = new();
Console.WriteLine(solution.RobotSim([4, -1, 3], []));
Console.WriteLine(solution.RobotSim([4, -1, 4, -2, 4], [[2, 4]]));
Console.WriteLine(solution.RobotSim([6, -1, -1, 6], []));
Console.WriteLine(solution.RobotSim([-2, -1, 8, 9, 6], [[-1, 3], [0, 1], [-1, 5], [-2, -4], [5, 4], [-2, -3], [5, -1], [1, -1], [5, 5], [5, 2]]));
