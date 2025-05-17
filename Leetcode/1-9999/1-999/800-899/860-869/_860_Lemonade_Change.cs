namespace Leetcode._1_9999._1_999._800_899._860_869;

public class _860_Lemonade_Change
{
    public bool LemonadeChange(int[] bills)
    {
        int five = 0;
        int ten = 0;
        foreach (int bill in bills)
        {
            switch (bill)
            {
                case 5:
                    five++;
                    break;
                case 10:
                    if (five >= 1)
                    {
                        ten++;
                        five--;
                    }
                    else
                    {
                        return false;
                    }
                    break;
                case 20:
                    if (ten >= 1 && five >= 1)
                    {
                        ten--;
                        five--;
                    }
                    else if (five >= 3)
                    {
                        five -= 3;
                    }
                    else
                    {
                        return false;
                    }
                    break;
            }
        }
        return true;
    }
}