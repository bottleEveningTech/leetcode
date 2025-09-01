
public partial class Solution
{
    public bool IsHappy(int n)
    {
        HashSet<int> numberWatched = new HashSet<int>();
        while (n !=1)
        {
            if(numberWatched.Contains(n))
            {
                return false;
            }
            numberWatched.Add(n);
            n = GetSum(n);
        }
        return true;
    }

    private int GetSum(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            int digit = n % 10;
            sum += digit * digit;
            n /= 10;
        }
        return sum;
    }
}