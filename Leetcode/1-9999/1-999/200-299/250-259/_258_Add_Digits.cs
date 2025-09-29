namespace Leetcode._1_9999._1_999._200_299._250_259;

public class _258_Add_Digits
{
    public int AddDigits(int num) {
        if (num < 10)
        {
            return num;
        }
        int result = 0;
        while (num > 0)
        {
            result += num % 10;
            num /= 10;
        }
        return AddDigits(result);
    }
}