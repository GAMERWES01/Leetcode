namespace Leetcode._1_9999._1_999._1_99._1_9;

public class _9_Palindrome_Number
{
    public bool IsPalindrome(int x) {

        if (x < 0)
        {
            return false;
        }
        string s = x.ToString();

        int check = s.Length / 2;

        for (int i = 0; i < check; i++)
        {
            if (s[i] != s[s.Length-1-i])
            {
                return false;
            }
        }
        return true;
    }
}