using Recover_Binary_Search_Tree;

TreeNode root1 = new(1, new(3, right: new(2)));
Solution solution = new();
solution.RecoverTree(root1);
Console.WriteLine();
