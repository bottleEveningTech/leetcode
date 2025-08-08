public partial class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        if(nums.Length > 0)
        {
            int lastElementIndex = nums.Length - 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] != val)
                {
                    break;
                }
                lastElementIndex--;
            }
            for (int i = 0; i <= lastElementIndex; i++)
            {
                if (nums[i] == val)
                {
                    nums[i] = nums[lastElementIndex];
                    do
                    {
                        lastElementIndex--;
                    } while (nums[lastElementIndex] == val);
                }
            }
            if(lastElementIndex < 0)
            {
                return 0;
            }
            return nums[lastElementIndex] != val ? (lastElementIndex + 1) : lastElementIndex;
        }
        return 0;
    }
}