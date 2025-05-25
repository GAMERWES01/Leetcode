using Leetcode.Classes;

namespace Leetcode._1_9999._1_999._1_99._90_99;

public class _94_Binary_Tree_Inorder_Traversal
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        List<int> list = new List<int>();
        Traversal(root, list);
        return list;
    }

    public void Traversal(TreeNode node, List<int> list)
    {
        if (node == null)
        {
            return;
        }
        Traversal(node.left, list);
        list.Add(node.val);
        Traversal(node.right, list);
    }
    
}