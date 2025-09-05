public partial class Solution
{ 
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int maxCount = 0;
        for (int i = 0; i < nums.Length;)
        {
            if (nums[i] == 1)
            {
                int j = i + 1;
                int count = 1;
                while (j < nums.Length && nums[j] == 1)
                {
                    count++;
                    j++;
                }
                i = j;
                maxCount = (count > maxCount) ? count : maxCount;
            }
            else
            {
                    i++;
            }
        }
        return maxCount;
    }
}