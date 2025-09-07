public partial class Solution
{
    public int Reverse(int x)
    {
        long rev = 0;

        while(x != 0)
        {
            int div = x % 10;
            x = x / 10;
            rev = rev * 10 + div;
            if(rev < int.MinValue || rev > int.MaxValue)
            {
                return 0;
            }
        }
        return (int)rev;
    }
}