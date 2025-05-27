using Leetcode.Classes;

namespace Leetcode._1_9999._1_999._100_199._110_119;

public class _110_Balanced_Binary_Tree
{
    public bool IsBalanced(TreeNode root) {
        if (root == null)
        {
            return true;
        }

        return Math.Abs(TreeHeight(root.left) - TreeHeight(root.right)) <= 1
               && IsBalanced(root.left)
               && IsBalanced(root.right);
    }


    public int TreeHeight(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        
        return Math.Max(TreeHeight(root.left), TreeHeight(root.right)) + 1;
    }
    
}