namespace Leetcode._1_9999._1_999._900_999._910_919;

public class _912_Sort_an_Array
{
    public int[] SortArray(int[] nums) {
        MergeSort(nums);
        return nums;
    }

    public void MergeSort(int[] nums)
    {
        int lenght = nums.Length;

        if (lenght <= 1)
        {
            return;
        }
        int midel = nums.Length / 2;
        
        int[] left = new int[midel];
        int[] right = new int[lenght-midel];

        int j = 0;
        for (int i = 0; i < lenght; i++)
        {
            if (i < midel)
            {
                left[i] = nums[i];
            }
            else
            {
                right[j] = nums[i];
                j++;
            }
        }
        MergeSort(left);
        MergeSort(right);
        Merge(nums, left, right);
    }

    public void Merge(int[] nums, int[] left, int[] right)
    {
        int i = 0, l = 0, r = 0;
        
        while (l < left.Length && r < right.Length)
        {
            if (left[l] < right[r])
            {
                nums[i] = left[l];
                l++;
            }
            else
            {
                nums[i] = right[r];
                r++;
            }

            i++;
        }

        while (l < left.Length)
        {
            nums[i] = left[l];
            l++;
            i++;
        }

        while (r < right.Length)
        {
            nums[i] = right[r];
            r++;
            i++;
        }
        
    }
    
}