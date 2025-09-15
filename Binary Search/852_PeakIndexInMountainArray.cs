public partial class Solution
{
    public int PeakIndexInMountainArray(int[] arr)
    {
        //this is a bitonic array means it increases then decreases

        int start = 0;
        int end = arr.Length - 1;

        while (start <= end)
        {
            int mid = start + (end - start) / 2;

            if (mid > 0 && mid < arr.Length - 1)
            {
                if (arr[mid] > arr[mid - 1] && arr[mid] > arr[mid + 1])
                {
                    return mid;
                }
                else if (arr[mid - 1] < arr[mid] && arr[mid] < arr[mid + 1])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            else if (mid == 0)
            {
                if (arr[0] > arr[1])
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            else if (mid == arr.Length - 1)
            {
                if (arr[arr.Length - 1] > arr[arr.Length - 2])
                {
                    return arr.Length - 1;
                }
                else
                {
                    return arr.Length - 2;
                }

            }
        }
        return start;
    }

}