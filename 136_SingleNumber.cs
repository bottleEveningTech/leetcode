public class Solution
{
	public int SingleNumber(int[] nums)
	{
		int xorVar = 0;
		for(int i = 0; i< nums.Length; i++)
		{
			xorVar = xorVar ^ nums[i];
		}
		return xorVar;
	}
}