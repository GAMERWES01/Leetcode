using Leetcode.Classes;

namespace Leetcode._1_9999._1_999._1_99._20_29;

public class _21_Merge_Two_Sorted_Lists
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {

        ListNode dum = new ListNode();
        ListNode cur = dum;

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                cur.next = list1;
                list1 = list1.next;
            }
            else
            {
                cur.next = list2;
                list2 = list2.next;
            }
            cur = cur.next;
        }

        if (list1 != null)
            cur.next = list1;
        else
            cur.next = list2;
        

        return dum.next;
    }
}