using Leetcode.Classes;

namespace Leetcode._1_9999._1_999._200_299._220_229;

public class _222_Count_Complete_Tree_Nodes
{
    public int CountNodes(TreeNode root) {
        if (root == null)
        {
            return 0;
        }
        return CountNodes(root.left) + CountNodes(root.right) + 1;
    }
}