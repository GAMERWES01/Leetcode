namespace Leetcode._1_9999._1_999._1_99._30_39;

public class _35_Search_Insert_Position
{
    public int SearchInsert(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] >= target)
            {
                return i;
            }
        }
        return nums.Length;
    }
}