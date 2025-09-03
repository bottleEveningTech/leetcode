public partial class Solution
{
    //changed method name to avoid conflict
    public int SearchRotatedArray(int[] nums, int target)
    {
        int minIndex = GetMinIndex(nums);
        if (nums[minIndex] == target)
        {
            return minIndex;
        }
        else
        {
            int res1 = BinarySearch(nums, target, 0, minIndex - 1);
            int res2 = BinarySearch(nums, target, minIndex + 1, nums.Length - 1);

            return res1 != -1 ? res1 : res2;
        }

    }
    public static int GetMinIndex(int[] nums)
    {
        int start = 0;
        int end = nums.Length - 1;
        int N = nums.Length;

        while (start <= end)
        {
            if (nums[start] <= nums[end])
            {
                return start;
            }
            int mid = start + (end - start) / 2;
            int next = (mid + 1) % nums.Length;
            int previous = (mid - 1 + N) % N;

            if (nums[mid] <= nums[next] && nums[mid] <= nums[previous])
            {
                return mid;
            }
            else if (nums[start] <= nums[mid])
            {
                start = mid + 1;
            }
            else if (nums[mid] <= nums[end])
            {
                end = mid - 1;
            }
        }
        return -1;
    }

    public static int BinarySearch(int[] nums, int target, int start, int end)
    {
        while (start <= end)
        {
            int mid = start + (end - start) / 2;
            if (nums[mid] == target)
            {
                return mid;
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
        return -1;
    }
}