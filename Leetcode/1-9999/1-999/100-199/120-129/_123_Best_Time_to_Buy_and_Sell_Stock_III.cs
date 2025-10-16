namespace Leetcode._1_9999._1_999._100_199._120_129;

public class _123_Best_Time_to_Buy_and_Sell_Stock_III
{
    public int MaxProfit(int[] prices)
    {
        if (prices.Length < 2)
            return 0;
        
        int n = prices.Length;
        int[] leftProfit = new int[n];
        int[] rightProfit = new int[n];
        
        int minPrice = prices[0];
        for (int i = 1; i < n; i++)
        {
            minPrice = Math.Min(minPrice, prices[i]);
            leftProfit[i] = Math.Max(leftProfit[i - 1], prices[i] - minPrice);
        }

        int maxPrice = prices[n - 1];
        for (int i = n - 2; i >= 0; i--)
        {
            maxPrice = Math.Max(maxPrice, prices[i]);
            rightProfit[i] = Math.Max(rightProfit[i + 1], maxPrice - prices[i]);
        }
        
        int maxProfit = 0;
        for (int i = 0; i < n; i++)
        {
            maxProfit = Math.Max(maxProfit, leftProfit[i] + rightProfit[i]);
        }

        return maxProfit;
        
    }
}