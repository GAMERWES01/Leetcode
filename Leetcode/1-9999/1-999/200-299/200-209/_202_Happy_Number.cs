namespace Leetcode._1_9999._1_999._200_299._200_209;

public class _202_Happy_Number
{
    public bool IsHappy(int n)
    {
        HashSet<int> loop = new HashSet<int>();
        while (true)
        {
            if (loop.Contains(n))
            {
                return false;
            }
            if (n == 1)
            {
                return true;
            }
            loop.Add(n);
            int result = 0;
            while (n > 0)
            {
                int digit = n % 10;
                n /= 10;
                result += digit * digit;
            }

            n = result;
        }
    }
}