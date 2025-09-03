public partial class Solution
{
    public int FindMin(int[] nums)
    {
        // idea is no. of times rotated is equal to index of min element and we will call it pivot in this case

        //move to unsorted part of array where pivot is present
        int start = 0;
        int end = nums.Length - 1;
        int  N = nums.Length;
        while (start <= end)
        {
            if (nums[start] <= nums[end])
            {
                //array is sorted between start and end, so start is the min element
                return nums[start];
            }
            int mid = start + (end - start) / 2;
            int next = (mid + 1) % nums.Length;
            int previous = (mid - 1 + N) % N;

            if (nums[mid] <= nums[next] && nums[mid] <= nums[previous])
            {
                return nums[mid];
            }
            else if (nums[start] <= nums[mid])
            {
                //the left part is sorted, so pivot should be in right part
                start = mid + 1;
            }
            else if (nums[mid] <= nums[end])
            {
                //the right part is sorted, so pivot should be in left part
                end = mid - 1;
            }
        }

        return -1;
    }
}