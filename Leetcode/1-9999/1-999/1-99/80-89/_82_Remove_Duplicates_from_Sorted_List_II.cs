using Leetcode.Classes;

namespace Leetcode._1_9999._1_999._1_99._80_89;

public class _82_Remove_Duplicates_from_Sorted_List_II
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return head;
        }
        ListNode dum = new ListNode(0, head);
        ListNode cur = dum;

        while (cur.next != null && cur.next.next != null)
        {
            if (cur.next.val == cur.next.next.val)
            {
                int dub = cur.next.val;
                while (cur.next != null && cur.next.val == dub)
                {
                    cur.next = cur.next.next;
                }
            }
            else
            {
                cur = cur.next;
            }
        }

        return dum.next;
    }
}