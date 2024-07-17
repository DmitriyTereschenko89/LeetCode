using Delete_Nodes_And_Return_Forest;

Solution solution = new();
TreeNode root = new(1, new(2, new(4), new(5)), new(3, new(6), new(7)));
solution.DelNodes(root, [3, 5]);
