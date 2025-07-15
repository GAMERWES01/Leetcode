namespace Leetcode._1_9999._1_999._1_99._10_19;

public class _17_Letter_Combinations_of_a_Phone_Number
{
    public IList<string> LetterCombinations(string digits)
    {
        if (string.IsNullOrEmpty(digits)) return new List<string>();
        
        string[] mapping =
        [
            "",     // 0
            "",     // 1
            "abc",  // 2
            "def",  // 3
            "ghi",  // 4
            "jkl",  // 5
            "mno",  // 6
            "pqrs", // 7
            "tuv",  // 8
            "wxyz"  // 9
        ];
        
        List<string> combinations = new List<string>{""};
        
        foreach (char digit in digits)
        {
            List<string> combinations2 = new List<string>(combinations.Count);
            int num = digit - '0';

            foreach (string combination in combinations)
            {
                foreach (char letter in mapping[num])
                {
                    combinations2.Add(combination + letter);
                }
            }

            combinations = combinations2;
        }
        
        return combinations;
    }
}