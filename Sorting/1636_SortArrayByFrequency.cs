public partial class Solution
{
    public int[] FrequencySort(int[] nums)
    {
        return nums.OrderBy(x => nums.Count(n=> n== x)).ThenByDescending(x => x).ToArray();
    }
}