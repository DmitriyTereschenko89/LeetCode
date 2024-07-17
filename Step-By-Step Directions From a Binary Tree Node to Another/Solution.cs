namespace Step_By_Step_Directions_From_a_Binary_Tree_Node_to_Another
{
    using System.Text;

    internal class Solution
    {
        private TreeNode LowestCommonAncestor(TreeNode node, int starValue, int destValue)
        {
            if (node is null)
            {
                return null;
            }

            if (node.val == starValue || node.val == destValue) 
            {
                return node;
            }

            TreeNode leftNode = LowestCommonAncestor(node.left, starValue, destValue);
            TreeNode rightNode = LowestCommonAncestor(node.right, starValue, destValue);

            if (leftNode is null)
            {
                return rightNode;
            }
            else if (rightNode is null)
            {
                return leftNode;
            }

            return node;
        }

        private bool FindPath(TreeNode node, int destination, StringBuilder path)
        {
            if (node is null)
            {
                return false;
            }

            if (node.val == destination)
            {
                return true;
            }

            path.Append('L');
            if (FindPath(node.left, destination, path))
            {
                return true;
            }

            path.Remove(path.Length - 1, 1);
            path.Append('R');
            if (FindPath(node.right, destination, path))
            {
                return true;
            }

            path.Remove(path.Length - 1, 1);
            return false;
        }

        public string GetDirections(TreeNode root, int startValue, int destValue)
        {
            TreeNode lowestCommonAncestor = LowestCommonAncestor(root, startValue, destValue);
            StringBuilder pathToRoot = new();
            StringBuilder pathToDest = new();
            StringBuilder path = new();

            FindPath(lowestCommonAncestor, startValue, pathToRoot);
            FindPath(lowestCommonAncestor, destValue, pathToDest);
            
            path.Append(new string('U', pathToRoot.Length));
            path.Append(pathToDest);

            return path.ToString();
        }
    }
}
