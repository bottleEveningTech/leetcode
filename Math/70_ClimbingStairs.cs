public partial class Solution
{
    public int ClimbStairs(int n)
    {
        int a = 1;
        int b = 2;

        for(int i=3; i <= n; i++)
        {
            int temp = b;
            b = a + b;
            a = temp;
        }

        return n == 1 ? 1 : b;

    }
}