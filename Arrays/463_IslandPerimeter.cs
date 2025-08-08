public partial class Solution
{
    public int IslandPerimeter(int[][] grid)
    {
        int perimeter = 0;
        int rows = grid.Length;
        int columns = grid[0].Length;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {

                if (grid[i][j] == 1)
                {

                    if (j == 0 || grid[i][j - 1] == 0)
                    {
                        perimeter++;
                    }
                    if (i == 0 || grid[i - 1][j] == 0)
                    {
                        perimeter++;
                    }
                    if (j == columns - 1 || grid[i][j + 1] == 0)
                    {
                        perimeter++;
                    }
                    if (i == rows - 1 || grid[i + 1][j] == 0)
                    {
                        perimeter++;
                    }
                }

            }
        }
        return perimeter;
    }
}