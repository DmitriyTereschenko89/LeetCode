namespace Number_of_Good_Leaf_Nodes_Pairs
{
    using System.Collections.Generic;

    internal class Solution
    {
        private void InitDataStructures(Dictionary<TreeNode, List<TreeNode>> adj, TreeNode node, TreeNode parent, HashSet<TreeNode> leafs)
        {
            if (node is null)
            {
                return;
            }

            adj[node] = adj.GetValueOrDefault(node, []);
            if (parent != null)
            {
                adj[node].Add(parent);
            }

            if (node.left != null)
            {
                adj[node].Add(node.left);
            }
            if (node.right != null)
            {
                adj[node].Add(node.right);
            }

            if (node.left is null && node.right is null)
            {
                leafs.Add(node);
            }

            InitDataStructures(adj, node.left, node, leafs);
            InitDataStructures(adj, node.right, node, leafs);
        }

        public int CountPairs(TreeNode root, int distance)
        {
            int ans = 0;
            Dictionary<TreeNode, List<TreeNode>> adj = [];
            HashSet<TreeNode> leafs = [];
            
            InitDataStructures(adj, root, null, leafs);
            foreach (TreeNode leaf in leafs)
            {
                Queue<TreeNode> queue = [];
                HashSet<TreeNode> visited = [];
                queue.Enqueue(leaf);
                visited.Add(leaf);
                for (int dist = 0; dist <= distance; ++dist)
                {
                    int queueSize = queue.Count;
                    for (int size = 0; size < queueSize; ++size)
                    {
                        TreeNode node = queue.Dequeue();
                        if (leafs.Contains(node) && node != leaf)
                        {
                            ++ans;
                        }

                        foreach (TreeNode neighbor in adj[node] ?? [])
                        {
                            if (visited.Contains(neighbor))
                            {
                                continue;
                            }

                            visited.Add(neighbor);
                            queue.Enqueue(neighbor);
                        }
                    }
                }
            }

      
            return ans / 2;
        }
    }
}
