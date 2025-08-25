public partial class Solution
{
    public int MySqrt(int x)
    {
        int count = 0;
        for(int i =1; x >= 0 ;i = i + 2)
        {
            x = x - i;
            count ++;
        }
        return count - 1;

    }
}