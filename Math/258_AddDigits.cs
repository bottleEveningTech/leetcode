public partial class Solution
{
    public int AddDigits(int num)
    {
        while (num > 9)
        {
            int sum = 0;
            int x = num;
            while (x > 0)
            {
                sum = sum + x % 10;
                x = x / 10;
            }
            num = sum;
        }
        return num;
    }
}