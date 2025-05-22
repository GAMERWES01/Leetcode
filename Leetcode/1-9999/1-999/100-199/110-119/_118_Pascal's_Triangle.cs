namespace Leetcode._1_9999._1_999._100_199._110_119;

public class _118_Pascal_s_Triangle
{
    public IList<IList<int>> Generate(int numRows) {
        
        List<IList<int>> cols = new List<IList<int>>();
        for (int i = 0; i < numRows; i++)
        {
            List<int> row = new List<int>();
            for (int j = 0; j <= i; j++)
            {
                if (j == 0 || j == i )
                {
                    row.Add(1);
                }
                else
                {
                    row.Add(cols[i - 1][j - 1] + cols[i - 1][j]);
                }
            }
            cols.Add(row);
            
        }
        return cols;
    }
}