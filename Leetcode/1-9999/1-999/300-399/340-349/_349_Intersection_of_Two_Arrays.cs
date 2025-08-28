namespace Leetcode._1_9999._1_999._300_399._340_349;

public class _349_Intersection_of_Two_Arrays
{
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> visited = new(nums1);
        List<int> result = new();
        foreach (int num in nums2)
        {
            if (visited.Contains(num))
            {
                result.Add(num);
                visited.Remove(num);
            }
        }
        return result.ToArray();
    }
}