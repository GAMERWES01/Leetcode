namespace Leetcode._1_9999._1_999._1_99._1_9;

public class _1_Two_Sum
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (dic.ContainsKey(target - nums[i]))
            {
                return new int[]
                {
                    i, dic[target - nums[i]]
                };
            }
            else if (!dic.ContainsKey(nums[i]))
            {
                dic.Add(nums[i], i);
            }
        }
        return new int[1];
    }
}