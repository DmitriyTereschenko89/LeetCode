namespace Delete_Nodes_And_Return_Forest
{
    using System.Collections.Generic;

    internal class Solution
    {
        public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete)
        {
            if (root is null)
            {
                return [];
            }

            HashSet<int> deleted = new HashSet<int>(to_delete);
            List<TreeNode> forest = [];
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();

                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                    if (deleted.Contains(node.left.val))
                    {
                        node.left = null;
                    }
                }

                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                    if (deleted.Contains(node.right.val))
                    {
                        node.right = null;
                    }
                }

                if (deleted.Contains(node.val))
                {
                    if (node.left != null)
                    {
                        forest.Add(node.left);
                    }

                    if (node.right != null)
                    {
                        forest.Add(node.right);
                    }
                }
            }

            if (!deleted.Contains(root.val))
            {
                forest.Add(root);
            }

            return forest;
        }
    }
}
