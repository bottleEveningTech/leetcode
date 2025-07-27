public class Solution
{
	public int CountHillValley(int[] nums)
	{
		int count = 0;
		List<int> duplicateRemoved = new List<int>();
		duplicateRemoved.Add(nums[0]);
		for (int i = 1; i < nums.Length; i++)
		{
			if (nums[i] != nums[i - 1])
				duplicateRemoved.Add(nums[i]);
		}

		for (int i = 1; i< duplicateRemoved.Count-1; i++)
		{
			if (duplicateRemoved[i] > duplicateRemoved[i - 1] && duplicateRemoved[i] > duplicateRemoved[i+1])
			{
				count++;
			}
			else if (duplicateRemoved[i] < duplicateRemoved[i - 1] && duplicateRemoved[i]  < duplicateRemoved[i + 1])
			{
				count++;
			}
		}
		return count;
	}
}