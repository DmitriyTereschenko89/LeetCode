namespace Walking_Robot_Simulation
{
    internal class Solution
    {
        public int RobotSim(int[] commands, int[][] obstacles)
        {
            (int, int)[] directions = [(0, 1), (1, 0), (0, -1), (-1, 0)];
            HashSet<(int, int)> obstacleHash = [];
            foreach (int[] obstacle in obstacles)
            {
                obstacleHash.Add((obstacle[0], obstacle[1]));
            }

            int x = 0;
            int y = 0;
            int dir = 0;
            int maxPath = 0;
            foreach (int command in commands)
            {
                if (command == -1)
                {
                    dir = (dir + 1) % 4;
                }
                else if (command == -2)
                {
                    dir = Math.Abs(dir - 1) % 4;
                }
                else
                {
                    var (dx, dy) = directions[dir];
                    for (int i = 0; i < command; ++i)
                    {
                        if (obstacleHash.Contains((x + dx, y + dy)))
                        {
                            break;
                        }

                        x += dx;
                        y += dy;
                    }
                }

                maxPath = Math.Max(maxPath, x * x + y * y);
            }

            return maxPath;
        }
    }
}
