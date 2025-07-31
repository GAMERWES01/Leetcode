namespace Leetcode._1_9999._1_999._1_99._10_19;

public class _11_Container_With_Most_Water
{
    public int MaxArea(int[] height) {

        int maxArea = 0;

        int i = 0;
        
        int j = height.Length - 1;
        
        foreach (int h in height)
        {
            int min =  Math.Min(height[i], height[j]);
            int area = min * (j - i);
            maxArea = Math.Max(maxArea, area);

            if (height[i] <= height[j])
            {
                i++;
            }
            else
            {
                j--;
            }
            
        }
        return maxArea;
    }
}