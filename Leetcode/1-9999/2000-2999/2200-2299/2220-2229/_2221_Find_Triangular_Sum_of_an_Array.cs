namespace Leetcode._1_9999._2000_2999._2200_2299._2220_2229;

public class _2221_Find_Triangular_Sum_of_an_Array
{
    public int TriangularSum(int[] nums) {
        for (int i = 1; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length-i; j++)
            {
                nums[j] = (nums[j] + nums[j + 1]) % 10;
            }
        }
        return nums[0];
    }
}