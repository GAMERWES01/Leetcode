namespace Leetcode._1_9999._1000_1999._1900_1999._1920_1929;

public class _1925_Count_Square_Sum_Triples
{
    public int CountTriples(int n)
    {
        int result = 0;

        for (int i = 5; i <= n; i++)
        {
            int target = i * i;
            
            int left = 1;
            int right = i - 1;

            while (left < right)
            {
                int sum = left * left + right * right;
                if (sum == target)
                {
                    result += 2;
                    left++;
                    right--;
                }
                else if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }
        return result;
    }
}