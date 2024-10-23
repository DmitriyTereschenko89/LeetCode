namespace Recover_Binary_Search_Tree
{
    internal class Solution
    {
        public void RecoverTree(TreeNode root)
        {
            TreeNode prev = null;
            TreeNode first = null;
            TreeNode second = null;
            TreeNode cur = root;
            while (cur != null)
            {
                if (cur.left is null)
                {
                    if (prev is null || (prev.val < cur.val))
                    {
                        prev = cur;
                    }
                    else
                    {
                        if (first is null)
                        {
                            first = prev;
                        }

                        second = cur;
                    }

                    cur = cur.right;
                }
                else
                {
                    TreeNode predcessor = cur.left;
                    while (predcessor.right != null && predcessor.right != cur)
                    {
                        predcessor = predcessor.right;
                    }

                    if (predcessor.right == null)
                    {
                        predcessor.right = cur;
                        cur = cur.left;
                    }
                    else
                    {
                        predcessor.right = null;
                        if (prev is null || (prev.val < cur.val))
                        {
                            prev = cur;
                        }
                        else
                        {
                            if (first is null)
                            {
                                first = prev;
                            }

                            second = cur;
                        }

                        cur = cur.right;
                    }
                }
            }

            (first.val, second.val) = (second.val, first.val);
        }
    }
}
