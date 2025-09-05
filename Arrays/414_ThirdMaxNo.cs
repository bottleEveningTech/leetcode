public partial class Solution
{
    public int ThirdMax(int[] nums)
    {
        long firstMax = long.MinValue;
        long secondMax = long.MinValue;
        long thirdMax = long.MinValue;
        foreach (int num in nums)
        {
            if (num == firstMax || num == secondMax || num == thirdMax)
            {
                continue;
            }
            if (num > firstMax)
            {
                thirdMax = secondMax;
                secondMax = firstMax;
                firstMax = num;
            }
            else if (num > secondMax)
            {
                thirdMax = secondMax;
                secondMax = num;
            }
            else if (num > thirdMax)
            {
                thirdMax = num;

            }
        }
        return thirdMax == long.MinValue ? (int)firstMax : (int)thirdMax;
    }
}