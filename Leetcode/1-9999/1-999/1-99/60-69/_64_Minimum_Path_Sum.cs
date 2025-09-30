namespace Leetcode._1_9999._1_999._1_99._60_69;

public class _64_Minimum_Path_Sum
{
    public int MinPathSum(int[][] grid)
    {
        int m = grid.Length;
        int n = grid[0].Length;
        int[,] minpad = new int[m, n];
        minpad[0, 0] = grid[0][0];

        for (int i = 1; i < m; i++)
        {
            minpad[i, 0] = grid[i][0] + minpad[i-1, 0];
        }

        for (int i = 1; i < n; i++)
        {
            minpad[0, i] = grid[0][i] + minpad[0, i-1];
        }

        for (int i = 1; i < m; i++)
        {
            for (int j = 1; j < n; j++)
            {
                minpad[i, j] = Math.Min(minpad[i - 1, j], minpad[i, j - 1]) + grid[i][j];
            }
        }
        return minpad[m - 1, n - 1];
    }
}