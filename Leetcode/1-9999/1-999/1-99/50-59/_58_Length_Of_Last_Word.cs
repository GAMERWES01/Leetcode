namespace Leetcode._1_9999._1_999._1_99._50_59;

public class _58_Length_Of_Last_Word
{
    public int LengthOfLastWord(string s)
    {
        bool nextword = false;
        int totaal = 0;
        foreach (char c in s)
        {
            if (c == ' ')
            {
                nextword = true;
                continue;
            }

            if (nextword)
            {
                nextword = false;
                totaal = 0;
            }

            totaal++;

        }

        return totaal;
    }
}