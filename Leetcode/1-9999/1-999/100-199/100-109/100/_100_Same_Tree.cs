namespace Leetcode._1_9999._1_999._100_199._100_109._100;

public class _100_Same_Tree
{
    
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null && q == null)
        {
            return true;
        }

        if (p == null || q == null)
        {
            return false;
        }
        if (p.val != q.val )
        {
            return false;
        }

        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}