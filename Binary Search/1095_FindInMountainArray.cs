/**
 * // This is MountainArray's API interface.
 * // You should not implement it, or speculate about its implementation

 * }
 */
//class MountainArray
//{
//    public static int Get(int index) { }
//    public int Length() { }
//}
    public partial class Solution
{
    public int FindInMountainArray(int target, MountainArray mountainArr)
    {
        int m = mountainArr.Length();
        int index = PeakIndexInMountainArray(mountainArr, m);
        int res1 = Search(mountainArr, 0, index, target, true);
        int res2 = Search(mountainArr, index + 1, m - 1, target, false);
        return res1 != -1 ? res1 : res2;
    }

    public int Search(MountainArray mountainArr, int start, int end, int target, bool isAscending)
    {
        while (start <= end)
        {
            int mid = start + (end - start) / 2;
            int midVal = mountainArr.Get(mid);

            if (midVal == target)
            {
                return mid;
            }

            if (isAscending)
            {
                if (midVal < target)
                    start = mid + 1;
                else
                    end = mid - 1;
            }
            else
            {
                if (midVal > target)
                    start = mid + 1;
                else
                    end = mid - 1;
            }
        }
        return -1;
    }

    public int PeakIndexInMountainArray(MountainArray mountainArr, int length)
    {
        int start = 0;
        int end = length - 1;

        while (start < end)
        {
            int mid = start + (end - start) / 2;
            if (mountainArr.Get(mid) < mountainArr.Get(mid + 1))
                start = mid + 1;
            else
                end = mid;
        }

        return start;
    }
}
