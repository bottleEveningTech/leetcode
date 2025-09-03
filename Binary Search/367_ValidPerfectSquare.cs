public partial class Solution
{
    public bool IsPerfectSquare(int num)
    {
        if (num == 1)
        {
            return true;
        }
        int start = 2;
        int end = num / 2;

        while (start <= end)
        {
            int mid = start + (end - start) / 2;
            long squareNumber = (long)mid * mid;

            if (squareNumber == num)
            {
                return true;
            }
            else if (squareNumber < num)
            {
                start = mid + 1;
            }
            else
            {
                end = mid - 1;
            }
        }
        return false;
    }
}