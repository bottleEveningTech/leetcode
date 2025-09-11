public partial class Solution
{
    public int[] GetNoZeroIntegers(int n)
    {
        for (int a = 1; a < n; a++)
        {
            int b = n - a;
            if (IsNoZero(a) && IsNoZero(b))
            {
                return new int[] { a, b };
            }
        }
        return new int[0];
    }

    private bool IsNoZero(int x)
    {
        while (x > 0)
        {
            if (x % 10 == 0)
            {
                return false;
            }
            x = x / 10;
        }
        return true;
    }
}