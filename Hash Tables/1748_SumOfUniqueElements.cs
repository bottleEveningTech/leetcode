public partial class Solution
{
    public int SumOfUnique(int[] nums)
    {
        Dictionary<int, int> freqList = new Dictionary<int, int>();
        int sum = 0;
        foreach (int num in nums)
        {
            if (!freqList.ContainsKey(num))
            {
                freqList[num] = 1;
            }
            else
            {
                freqList[num]++;
            }
        }
        foreach (var x in freqList)
        {
            if (x.Value == 1)
            {
                sum += x.Key;
            }
        }
        return sum;
    }
}