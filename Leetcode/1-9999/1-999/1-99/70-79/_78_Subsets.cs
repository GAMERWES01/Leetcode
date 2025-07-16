namespace Leetcode._1_9999._1_999._1_99._70_79;

public class _78_Subsets
{
    public IList<IList<int>> Subsets(int[] nums)
    {
        List<IList<int>> result = new List<IList<int>>();
        result.Add(new List<int>());
        foreach (int num in nums)
        {
            int count = result.Count;
            for (int i = 0; i < count; i++)
            {
                List<int> newSubset = new List<int>(result[i]);
                newSubset.Add(num);
                result.Add(newSubset);
            }
        }
        return result;
    }
}