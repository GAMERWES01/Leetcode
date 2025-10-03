using Leetcode.Classes;

namespace Leetcode._1_9999._1_999._200_299._230_239;

public class _237_Delete_Node_in_a_Linked_List
{
    public void DeleteNode(ListNode node) {
        node.val = node.next.val;
        node.next = node.next.next;
    }
}