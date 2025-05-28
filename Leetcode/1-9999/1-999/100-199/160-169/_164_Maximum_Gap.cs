namespace Leetcode._1_9999._1_999._100_199._160_169;

public class _164_Maximum_Gap
{
    public int MaximumGap(int[] nums) {

        if (nums.Length < 2)
        {
            return 0;
        }

        Array.Sort(nums);
        
        int gap = 0;

        for (int i = 0; i < nums.Length-1; i++)
        {
            int verschil = nums[i + 1] - nums[i];
            if (verschil > gap)
            {
                gap = verschil;
            }
        }
        return gap;
    }
}