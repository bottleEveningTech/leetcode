public class Solution
{
	public int[] TwoSum(int[] nums, int target)
	{
		for (int i = 0; i < nums.Length - 1; i++)
		{
			for (int j = i + 1; j < nums.Length; j++)
			{
				if (target == nums[i] + nums[j])
				{
					return new int[] { i, j };
				}
			}
		}
		return null;
	}
}