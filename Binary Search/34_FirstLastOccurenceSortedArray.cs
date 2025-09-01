public partial class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        int[] occurences = [-1, -1];

        FindOccurence(nums, target, occurences, true);
        FindOccurence(nums, target, occurences, false);

        return occurences;
    }

    private static void FindOccurence(int[] nums, int target, int[] occurences, bool isFirstOccurence)
    {
        int start = 0;
        int end = nums.Length - 1;

        while (start <= end)
        {
            int mid = start + (end - start) / 2;
            if (nums[mid] == target)
            {
                if (isFirstOccurence)
                {
                    occurences[0] = mid;
                    end = mid - 1;
                }
                else
                {
                    occurences[1] = mid;
                    start = mid + 1;
                }

            }
            else if (nums[mid] < target)
            {
                start = mid + 1;
            }
            else
            {
                end = mid - 1;
            }
        }

    }
}
