namespace Leetcode._1_9999._1_999._300_399._330_339;

public class _344_Reverse_String
{
    public void ReverseString(char[] s)
    {
        int max = s.Length;
        int len = max / 2;
        max--;
        for (int i = 0; i < len; i++)
        {
            char temp = s[max - i];
            s[max - i] = s[i];
            s[i] = temp;
        }
    }
}