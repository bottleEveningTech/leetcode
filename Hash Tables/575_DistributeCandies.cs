public partial class Solution
{
    public int DistributeCandies(int[] candyType)
    {
        int size = candyType.Length/2;
        int distictTypes = new HashSet<int>(candyType).Count;
        return (size < distictTypes) ? size : distictTypes;
    }
}