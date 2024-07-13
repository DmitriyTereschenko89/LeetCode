using Robot_Collisions;

Solution solution = new();
//positions = [5,4,3,2,1], healths = [2,17,9,15,10], directions = "RRRRR"
Console.WriteLine(string.Join(", ", solution.SurvivedRobotsHealths([5,4,3,2,1], [2,17,9,15,10], "RRRRR")));
//positions = [3, 5, 2, 6], healths = [10, 10, 15, 12], directions = "RLRL"
Console.WriteLine(string.Join(", ", solution.SurvivedRobotsHealths([3, 5, 2, 6], [10, 10, 15, 12], "RLRL")));
//positions = [1,2,5,6], healths = [10,10,11,11], directions = "RLRL"
Console.WriteLine(string.Join(", ", solution.SurvivedRobotsHealths([1,2,5,6], [10,10,11,11], "RLRL")));
Console.WriteLine(string.Join(", ", solution.SurvivedRobotsHealths([3,47], [46,26], "LR")));
