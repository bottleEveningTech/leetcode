public partial class Solution
{
    public int HeightChecker(int[] heights)
    {
        int[] sortedHeights = heights.OrderBy(h => h).ToArray();
        int wrongHeightCount = 0;

        for (int i = 0; i < heights.Length; i++)
        {
            if (sortedHeights[i] != heights[i])
            {
                wrongHeightCount++;
            }
        }
        return wrongHeightCount;
    }
}