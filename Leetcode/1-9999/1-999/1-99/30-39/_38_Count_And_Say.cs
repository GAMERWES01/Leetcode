using System.Text;

namespace Leetcode._1_9999._1_999._1_99._30_39;

public class _38_Count_And_Say
{
    public string CountAndSay(int n) {
        string s = "1";
        for (int i = 1; i < n; i++)
        {
            s = RLE(s);
        }
        return s;
    }

    private string RLE(string s)
    {
        int count = 1;
        StringBuilder sb = new StringBuilder();
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i-1] == s[i])
            {
                count++;
            }
            else
            {
                sb.Append(count).Append(s[i - 1]);
                count = 1;
            }
        }
        sb.Append(count).Append(s[^1]);
        return sb.ToString();
    }
    
}