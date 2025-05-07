namespace Leetcode._1_9999._1_999._1_99._10_19;

public class _13_Roman_To_Integer
{
    
    int romanToInt(string s) {

        int totaal = 0;
        for (int i = s.Length-1; i >= 0; i--)
        {
            switch (s[i])
            {
                case 'I':
                    totaal++;
                    break;
                case 'V':
                    
                    if (i - 1 >= 0)
                    {
                        if (s[i - 1] == 'I')
                        {
                            i--;
                            totaal += 4;
                            break;
                        }
                    }
                    totaal += 5;
                    break;
                case 'X':
                    if (i - 1 >= 0)
                    {
                        if (s[i - 1] == 'I')
                        {
                            i--;
                            totaal += 9;
                            break;
                        }
                    }
                    totaal += 10;
                    break;
                case 'L':
                    if (i - 1 >= 0)
                    {
                        if (s[i - 1] == 'X')
                        {
                            i--;
                            totaal += 40;
                            break;
                        }
                    }
                    totaal += 50;
                    break;
                case 'C':
                    if (i - 1 >= 0)
                    {
                        if (s[i - 1] == 'X')
                        {
                            i--;
                            totaal += 90;
                            break;
                        }
                    }
                    totaal += 100;
                    break;
                case 'D':
                    if (i - 1 >= 0)
                    {
                        if (s[i - 1] == 'C')
                        {
                            i--;
                            totaal += 400;
                            break;
                        }
                    }
                    totaal += 500;
                    break;
                case 'M':
                    if (i - 1 >= 0)
                    {
                        if (s[i - 1] == 'C')
                        {
                            i--;
                            totaal += 900;
                            break;
                        }
                    }
                    totaal += 1000;
                    break;
            }
        }
        return totaal;
    }
    
}