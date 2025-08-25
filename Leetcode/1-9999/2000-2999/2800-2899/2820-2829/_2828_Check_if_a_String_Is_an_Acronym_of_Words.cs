namespace Leetcode._1_9999._2000_2999._2800_2899._2820_2829;

public class _2828_Check_if_a_String_Is_an_Acronym_of_Words
{
    public bool IsAcronym(IList<string> words, string s) {

        if (words.Count != s.Length)
        {
            return false;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (words[i][0] != s[i])
            {
                return false;
            }
        }
        
        return true;
    }
}