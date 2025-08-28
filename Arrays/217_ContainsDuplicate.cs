public partial class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> temp = new HashSet<int>();

        foreach (int num in nums)
        {
            if (temp.Contains(num))
            {
                return true;
            }
            temp.Add(num);
        }
        return false;
    }
}