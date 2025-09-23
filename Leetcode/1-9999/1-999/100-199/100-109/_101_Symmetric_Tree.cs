using Leetcode.Classes;

namespace Leetcode._1_9999._1_999._100_199._100_109;

public class _101_Symmetric_Tree
{
    public bool IsSymmetric(TreeNode root) {
        if (root == null)
        {
            return true;
        }
        return IsSymmetric(root.left, root.right);
    }

    public bool IsSymmetric(TreeNode left, TreeNode right)
    {
        if (left == null && right == null)
        {
            return true;
        }
        if (left == null || right == null)
        {
            return false;
        }
        if (left.val == right.val)
        {
            return IsSymmetric(left.left, right.right) && IsSymmetric(left.right, right.left);
        }
        return false;
    }

}