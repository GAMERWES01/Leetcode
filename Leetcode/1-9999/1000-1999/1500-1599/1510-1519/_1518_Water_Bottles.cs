namespace Leetcode._1_9999._1000_1999._1500_1599._1510_1519;

public class _1518_Water_Bottles
{
    public int NumWaterBottles(int numBottles, int numExchange)
    {
        int result = numBottles;
        int emty = numBottles;

        while (emty >= numExchange)
        {
            int newFull = emty / numExchange;
            result += newFull;
            emty %= numExchange;
            emty += newFull;
        }
        return result;
    }
}