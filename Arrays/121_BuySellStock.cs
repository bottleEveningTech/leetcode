public class Solution
{
	public int MaxProfit(int[] prices)
	{
		int minPrice = int.MaxValue;
		int maxPrice = 0;

		foreach (int price in prices)
		{
			if(price < minPrice)
			{
				minPrice = price;
			}
			int profit = price - minPrice;
			if (profit > maxPrice)
			{
				maxPrice = profit;
			}
		}
		return maxPrice;
	}
}