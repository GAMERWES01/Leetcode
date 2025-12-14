namespace Leetcode._1_9999._3000_3999._3600_3699._3600_3609;

public class _3606_Coupon_Code_Validator
{
    
    private static readonly Dictionary<string, int> CategorieVolgorde = new()
    {
        { "electronics", 0 },
        { "grocery", 1 },
        { "pharmacy", 2 },
        { "restaurant", 3 }
    };
    
    public IList<string> ValidateCoupons(string[] code, string[] businessLine, bool[] isActive) {
        var geldigeCoupons = new List<(string Code, string BusinessLine)>();

        for (int i = 0; i < code.Length; i++)
        {
            if (!isActive[i])
                continue;

            if (!CategorieVolgorde.ContainsKey(businessLine[i]))
                continue;

            if (string.IsNullOrEmpty(code[i]))
                continue;

            if (!code[i].All(c =>
                    (c >= 'a' && c <= 'z') ||
                    (c >= 'A' && c <= 'Z') ||
                    (c >= '0' && c <= '9') ||
                    c == '_'))
                continue;

            geldigeCoupons.Add((code[i], businessLine[i]));
        }

        return geldigeCoupons
            .OrderBy(c => CategorieVolgorde[c.BusinessLine])
            .ThenBy(c => c.Code, StringComparer.Ordinal)
            .Select(c => c.Code)
            .ToList();
    }
    
}