using Leetcode.Classes;

namespace Leetcode._1_9999._1_999._100_199._160_169;

public class _160_Intersection_of_Two_Linked_Lists
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        HashSet<ListNode> hashSet = new HashSet<ListNode>();

        while (headA != null)
        {
            hashSet.Add(headA);
            headA = headA.next;
        }

        while (headB != null)
        {
            if (hashSet.Contains(headB))
            {
                return headB;
            }
            headB = headB.next;
        }
        return null;
    }
}