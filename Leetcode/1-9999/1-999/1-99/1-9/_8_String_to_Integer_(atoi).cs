namespace Leetcode._1_9999._1_999._1_99._1_9;

public class _8_String_to_Integer__atoi_
{
    public int MyAtoi(string s) {
        int result = 0;
        bool furst = true;
        bool isNegative = false;
        foreach (char c in s)
        {
            if (char.IsDigit(c))
            {
                int digit = (c - '0');
                if (result > (int.MaxValue - digit) / 10)
                {
                    return isNegative ? int.MinValue : int.MaxValue;
                }
                furst = false;
                result = result * 10 + digit;
            }
            else
            {
                switch (c)
                {
                    case ' ':
                        if (furst)
                        {
                            break;
                        }
                        return isNegative ? -result : result;
                    case '+':
                        if (furst)
                        {
                            furst = false;
                            break;
                        }
                        return isNegative ? -result : result;
                    case '-':
                        if (furst)
                        {
                            furst = false;
                            isNegative = true;
                            break;
                        }
                        return isNegative ? -result : result;
                    default:
                        return isNegative ? -result : result;
                }
            }
        }
        return isNegative ? -result : result;
    }
}