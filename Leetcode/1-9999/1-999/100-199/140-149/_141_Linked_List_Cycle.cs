using Leetcode.Classes;

namespace Leetcode._1_9999._1_999._100_199._140_149;

public class _141_Linked_List_Cycle
{
    public bool HasCycle(ListNode head) {
        HashSet<ListNode> visited = new();
        while (head != null)
        {
            if (visited.Contains(head))
            {
                return true;
            }
            visited.Add(head);
            head = head.next;
        }
        return false;
    }
}