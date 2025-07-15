using Leetcode.Classes;

namespace Leetcode._1_9999._1_999._1_99._1_9;

public class _2_Add_Two_Numbers
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2, int cary = 0)
    {
        if (l1 == null && l2 == null && cary == 0)
        {
            return null;
        }
        int totaal = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + cary;
        cary = totaal / 10;
        return new ListNode(totaal % 10, AddTwoNumbers(l1?.next, l2?.next, cary));
    }
}