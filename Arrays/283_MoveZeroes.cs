public partial class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int swapRange = nums.Length - 1;
        for (int i = 0; i < swapRange; i++)
        {
            for (int j = i + 1; j <= swapRange; j++)
            {
                if (nums[i] == 0 && nums[j] != 0)
                {
                    (nums[i], nums[j]) = (nums[j], nums[i]);
                    break;
                }
            }

        }
    }
}