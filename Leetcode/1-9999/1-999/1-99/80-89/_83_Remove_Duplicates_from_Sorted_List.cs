using Leetcode.Classes;

namespace Leetcode._1_9999._1_999._1_99._80_89;

public class _83_Remove_Duplicates_from_Sorted_List
{
    public ListNode DeleteDuplicates(ListNode head) {
        if (head != null)
        {
            DeleteDuplicatesNext(head.next, head);
        }
        return head;
    }

    public void DeleteDuplicatesNext(ListNode head, ListNode vorige)
    {
        if (head != null)
        {
            if (head.val == vorige.val)
            {
                vorige.next = head.next;
                DeleteDuplicatesNext(head.next, vorige);
            }
            else
            {
                DeleteDuplicatesNext(head.next, head);
            }
        }
    }
    
}