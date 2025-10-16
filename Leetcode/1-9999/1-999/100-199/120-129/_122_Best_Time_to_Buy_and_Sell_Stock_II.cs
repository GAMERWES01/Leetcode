namespace Leetcode._1_9999._1_999._100_199._120_129;

public class _122_Best_Time_to_Buy_and_Sell_Stock_II
{
    // in dit bestand staan 2 oplossingen waarbij de 2de het efficentste is
    
    // eerste oplossing 
    // public int MaxProfit(int[] prices) {
    //     int maxProfit = 0;
    //     bool hasStock = false;
    //     int stock = 0;
    //     for (int i = 1; i < prices.Length; i++)
    //     {
    //         if (hasStock)
    //         {
    //             if (prices[i - 1] > prices[i])
    //             {
    //                 hasStock = false;
    //                 maxProfit += prices[i-1] - stock;
    //             }
    //         }
    //         else
    //         {
    //             if (prices[i - 1] < prices[i])
    //             {
    //                 hasStock = true;
    //                 stock = prices[i - 1];
    //             } 
    //         }
    //     }
    //     if (hasStock)
    //     {
    //         maxProfit += prices[^1] - stock; 
    //     }
    //     return maxProfit;
    // }
    
    //tweede oplosing
    
    public int MaxProfit(int[] prices)
    {
        int maxProfit = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            int profit = prices[i] - prices[i - 1];
            if (profit > 0)
            {
                maxProfit += profit;
            }
        }
        return maxProfit;
    }
}