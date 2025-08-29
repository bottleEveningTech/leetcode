public partial class Solution
{
    public int FindFinalValue(int[] nums, int original)
    {
        for(int i = 0; i< nums.Length; i++)
        {
            if(nums[i] == original)
            {
                original = original * 2;
                i = -1;
            }
        }
        return original;
    }
}