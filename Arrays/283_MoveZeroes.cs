public class Solution
{
	public void MoveZeroes(int[] nums)
	{
		int swapLimit = nums.Length - 1;
		for(int i = 0; i< swapLimit; i++)
		{
			for (int j = i; j < swapLimit - 1; j++)
			{
				if (nums[i] == 0)
				{
					(nums[i], nums[j]) = (nums[j], nums[i]);
					swapLimit--;
				}
			}
			
		}
	}
}