namespace Leetcode._1_9999._1_999._200_299._230_239;

public class _231_Power_of_Two
{
    public bool IsPowerOfTwo(int n) {
        long powerOfTwo = 1;
        while (powerOfTwo < n)
        {
            powerOfTwo *= 2;
        }
        return powerOfTwo == n;
    }
}