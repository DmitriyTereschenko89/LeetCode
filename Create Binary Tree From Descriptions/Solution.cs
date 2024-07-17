namespace Create_Binary_Tree_From_Descriptions
{
    internal class Solution
    {
        public TreeNode CreateBinaryTree(int[][] descriptions)
        {
            Dictionary<int, List<int>> parents = [];
            foreach (int[] node in descriptions)
            {
                if (!parents.TryGetValue(node[1], out List<int> value))
                {
                    value = ([]);
                    parents.Add(node[1], value);
                }

                value.Add(node[0]);
            }

            Dictionary<int, TreeNode> tree = [];
            foreach (int[] node in descriptions)
            {
                int parentNode = node[0];
                int childNode = node[1];
                bool isLeftChild = node[2] == 1;
                if (tree.TryGetValue(parentNode, out TreeNode value))
                {
                    tree[childNode] = tree.GetValueOrDefault(childNode, new(childNode));
                    if (isLeftChild)
                    {
                        value.left = tree[childNode];
                    }
                    else
                    {
                        value.right = tree[childNode];
                    }
                }
                else
                {
                    TreeNode parent = new(parentNode);
                    tree[childNode] = tree.GetValueOrDefault(childNode, new(childNode));
                    if (isLeftChild)
                    {
                        parent.left = tree[childNode];
                    }
                    else
                    {
                        parent.right = tree[childNode];
                    }

                    tree[parentNode] = parent;
                }               
            }

            TreeNode root = null;
            foreach (int parentNode in tree.Keys)
            {
                if (!parents.ContainsKey(parentNode))
                {
                    root = tree[parentNode];
                }
            }

            return root;
        }
    }
}
