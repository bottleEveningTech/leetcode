public partial class Solution
{
    public int FindRadius(int[] houses, int[] heaters)
    {
        int result = 0;
        Array.Sort(heaters);
        Array.Sort(houses);

        foreach (int house in houses)
        {
            int index = Array.BinarySearch(heaters, house);
            if(index < 0)
            {
                index = ~index;
            }
            int firstDist = index < heaters.Length ? Math.Abs(heaters[index] - house) : int.MaxValue;
            int secondDist = index > 0  ? Math.Abs(heaters[index - 1] - house) : int.MaxValue;

            int minDistance = Math.Min(firstDist, secondDist);
            result = Math.Max(result, minDistance);
        }

        return result;
    }
}