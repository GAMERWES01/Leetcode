namespace Leetcode._1_9999._1_999._1_99._60_69;

public class _67_Add_Binary
{
    public string AddBinary(string a, string b) {
        bool cary = false;
        string result = "";

        int alan = a.Length - 1;
        int blan = b.Length - 1;

        while (cary || alan >= 0 || blan >= 0)
        {
            if (alan >= 0 && blan >= 0)
            {
                if (a[alan] == '1' && b[blan] == '1' )
                {
                    if (cary)
                    {
                        result = "1" + result;
                    }
                    else
                    {
                        cary = true;
                        result = '0' + result;
                    }
                }
                else if (a[alan] == '1' || b[blan] == '1')
                {
                    if (cary)
                    {
                        result = '0' + result;
                    }
                    else
                    {
                        result = "1" + result;
                    }
                }
                else if (a[alan] == '0' && b[blan] == '0')
                {
                    if (cary)
                    {
                        cary = false;
                        result = "1" + result;
                    }
                    else
                    {
                        result = '0' + result;
                    }
                
                }
            }
            else if (alan >= 0)
            {
                if (a[alan] == '1' && cary)
                {
                    result = "0" + result;
                } 
                else if (a[alan] == '0' && cary)
                {
                    cary = false;
                    result = '1' + result;
                }
                else if (a[alan] == '1' )
                {
                    result = '1' + result;
                }
                else
                {
                    result = '0' + result;
                }
            }
            else if (blan >= 0)
            {
                if (b[blan] == '1' && cary)
                {
                    result = "0" + result;
                } 
                else if (b[blan] == '0' && cary)
                {
                    cary = false;
                    result = '1' + result;
                }
                else if (b[blan] == '1' )
                {
                    result = '1' + result;
                }
                else
                {
                    result = '0' + result;
                }
            }
            else
            {
                cary = false;
                result = '1' + result;
            }

            alan--;
            blan--;
        }
        return result;
    }

    
    
}