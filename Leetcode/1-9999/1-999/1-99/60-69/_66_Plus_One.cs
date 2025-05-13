namespace Leetcode._1_9999._1_999._1_99._60_69;

public class _66_Plus_One {
    public int[] PlusOne(int[] digits)
    {
        for (int i = digits.Length-1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }
            else
            {
                digits[i] = 0;
            }
        }
        int[] nieuw = new int[digits.Length + 1];
        nieuw[0] = 1;
        Array.Copy(digits, 0, nieuw, 1, digits.Length);
        return nieuw;
    }
}