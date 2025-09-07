public partial class Solution
{
    public void SortColors(int[] nums)
    {
        // using DNF algorithm
        int n = nums.Length;

        int low = 0;
        int mid = 0;
        int high =  n - 1;

        while(mid <= high)
        {
            if (nums[mid] == 0)
            {
                (nums[low], nums[mid]) = (nums[mid], nums[low]);
                mid++;
                low++;

            }
            else if (nums[mid] == 1)
            {
                mid++;
            }
            else
            {
                (nums[mid], nums[high]) = (nums[high], nums[mid]);
                high--;
            }
        }

    }
}