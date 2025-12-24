namespace Leetcode._1_9999._3000_3999._3000_3099._3070_3079;

public class _3074_Apple_Redistribution_into_Boxes
{
    public int MinimumBoxes(int[] apple, int[] capacity)
    {
        int totaal = apple.Sum();
        
        Array.Sort(capacity);
        Array.Reverse(capacity);

        int i = 0;
        while (totaal > 0)
        {
            totaal -= capacity[i];
            i++;
        }
        return i;
    }
}