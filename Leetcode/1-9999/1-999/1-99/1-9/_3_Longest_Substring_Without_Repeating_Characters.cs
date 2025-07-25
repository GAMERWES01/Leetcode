namespace Leetcode._1_9999._1_999._1_99._1_9;

public class _3_Longest_Substring_Without_Repeating_Characters
{
    public int LengthOfLongestSubstring(string s)
    {
        string result = "";
        
        string current = "";
        
        foreach (char c in s)
        {
            if (!current.Contains(c))
            {
                current += c;
                if (current.Length > result.Length)
                {
                    result = current;
                }
            }
            else
            {
                int index = current.IndexOf(c);
                current = current.Substring(index + 1);
                current += c;
            }
        }
        return result.Length;
    }
}