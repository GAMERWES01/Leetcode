namespace Leetcode._1_9999._1_999._1_99._50_59;

public class _50_Pow_x__n_
{
    public double MyPow(double x, int n)
    {
        if (n == 0)
        {
            return 1;
        }
        long exp = n;
        if (exp < 0)
        {
            x = 1 / x;
            exp = -exp;
        }
        double result = 1;
        while (exp > 0)
        {
            if (exp % 2 == 1)
            {
                result *= x;
            }
            x *= x;
            exp /= 2;
        }
        return result;
    }
}