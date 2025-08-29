public partial class Solution
{
    public int FindLucky(int[] arr)
    {
        Dictionary<int, int> freqList = new Dictionary<int, int>();
        List<int> luckyNums = new List<int>();
        foreach (int num in arr)
        {
            if(!freqList.ContainsKey(num))
            {
                freqList[num] = 1;
            }
            else
            {
                freqList[num]++;
            }
        }
        foreach(var x in freqList)
        {
            if(x.Key == x.Value)
            {
                luckyNums.Add(x.Key);
            }
        }
        return luckyNums.Count != 0 ? luckyNums.Max(): -1;
    }
}