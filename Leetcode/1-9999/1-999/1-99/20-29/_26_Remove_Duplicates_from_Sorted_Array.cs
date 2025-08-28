namespace Leetcode._1_9999._1_999._1_99._20_29;

public class _26_Remove_Duplicates_from_Sorted_Array
{
    public int RemoveDuplicates(int[] nums)
    {

        int k = 0;
        
        if (nums.Length == 0) {
            return 0;
        }

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[k] != nums[i])
            {
                k++;
                nums[k] = nums[i];
            }
        }
        
        return k + 1;
    }
}