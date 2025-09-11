public partial class Solution
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        Dictionary<int, int> freqCount = new Dictionary<int, int>();
        List<int> result = new List<int>();
        if(nums1.Length > nums2.Length)
        {
            var temp = nums1;
            nums1 = nums2;
            nums2 = temp;
        }
        foreach (int num in nums1)
        {
            if (!freqCount.ContainsKey(num))
            {
                freqCount[num] = 0;
            }
           freqCount[num]++;

        }

        foreach(int num in nums2)
        {
            if (freqCount.ContainsKey(num) && freqCount[num] > 0)
            {
                result.Add(num);
                freqCount[num]--;
            }
        }
        return result.ToArray();
    }
}