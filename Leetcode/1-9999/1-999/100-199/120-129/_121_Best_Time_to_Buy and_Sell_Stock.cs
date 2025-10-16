namespace Leetcode._1_9999._1_999._100_199._120_129;

public class _121_Best_Time_to_Buy_and_Sell_Stock
{
    public int MaxProfit(int[] prices)
    {
        int minPrice = int.MaxValue;
        int maxProfit = 0;
        foreach (int price in prices)
        {
            minPrice = Math.Min(minPrice, price);
            maxProfit = Math.Max(maxProfit, price-minPrice);
        }
        return maxProfit;
    }
}