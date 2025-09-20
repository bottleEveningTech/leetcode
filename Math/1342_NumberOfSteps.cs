public partial class Solution
{
    public int NumberOfSteps(int num)
    {
        int steps = 0;
        //Approach 1: Using normal math
        //while (num > 0)
        //{
        //    if (num % 2 == 0)
        //    {
        //        num /= 2;
        //    }
        //    else
        //    {
        //        num -= 1;
        //    }
        //    steps++;
        //}

        //Approach 2: Using bit manipulation
        while(num > 0)
        {
            if((num & 1) == 0)
            {
                num >>= 1;
            }
            else
            {
                num--;
            }
            steps++;
        }
        return steps;
    }
}