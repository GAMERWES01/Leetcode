namespace Leetcode._1_9999._1_999._1_99._20_29;

public class _27_Remove_Element
{
    public int RemoveElement(int[] nums, int val) {
        int total = 0;
        List<int> list = new List<int>();
        foreach (int num in nums)
        {
            if (num != val)
            {
                total++;
                list.Add(num);
            }
        }

        for (int i = 0; i < list.Count; i++)
        {
            nums[i] = list[i];
        }
        return total;
    }
}