using Leetcode.Classes;

namespace Leetcode._1_9999._1_999._100_199._100_109;

public class _104_Maximum_Depth_of_Binary_Tree
{
    public int MaxDepth(TreeNode root) {
        if (root == null)
        {
            return 0;
        }
        return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
    }
}