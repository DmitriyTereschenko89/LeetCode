using Number_of_Good_Leaf_Nodes_Pairs;

Solution solution = new();
TreeNode root = new(1, new(2, new(4), new(5)), new(3, new(6), new(7)));
TreeNode root1 = new(100);
Console.WriteLine(solution.CountPairs(root, 3));
Console.WriteLine(solution.CountPairs(root1, 1));
