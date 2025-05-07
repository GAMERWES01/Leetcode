namespace Leetcode._1_9999._1_999._1_99._10_19;

public class _14_Longest_Common_Prefix
{
    public string LongestCommonPrefix(string[] strs)
    {
        string prefix = strs[0];

        foreach (string str in strs.Skip(1))
        {
            string temp = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (prefix.Length == i || str[i] != prefix[i])
                {
                    break;
                }
                temp += str[i];
            }
            prefix = temp;
        }
        return prefix;
    }
}