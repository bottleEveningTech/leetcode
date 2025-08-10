public partial class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        if(nums1.Length < nums2.Length)
        {
           return Intersection(nums2, nums1);
        }
        return nums1.Where(x => nums2.Contains(x)).Distinct().ToArray();
    }
}