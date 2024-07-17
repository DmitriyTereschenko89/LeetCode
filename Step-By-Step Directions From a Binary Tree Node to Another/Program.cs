using Step_By_Step_Directions_From_a_Binary_Tree_Node_to_Another;

Solution solution = new();
TreeNode root = new(5, new(1, new(3)), new(2, new(6), new(4)));
Console.WriteLine(solution.GetDirections(root, 3, 6));
