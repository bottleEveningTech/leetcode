public class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        int[] sortedUniqueArray = nums.Distinct().OrderBy(x => x).ToArray();
        IList<int> disappearedElements = new List<int>();
        for (int i = 1; i <= nums.Length; i++)
        {
            if (!sortedUniqueArray.Contains(i))
            {
                disappearedElements.Add(i);
            }
        }
        return disappearedElements;
    }
}