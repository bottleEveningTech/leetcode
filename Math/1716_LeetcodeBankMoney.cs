public partial class Solution
{
    public int TotalMoney(int n)
    {
        int initialMoney = 1;
        int totalMoney = 0;
        for (int i = 1; i <= n; i++)
        {
            if(i % 7 == 0 && i != 1)
            {
                initialMoney++;
            }
            totalMoney += initialMoney + (i - 1) % 7;
        }
        
        return totalMoney;
    }
}