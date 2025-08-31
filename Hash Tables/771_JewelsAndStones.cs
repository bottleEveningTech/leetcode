public partial class Solution
{
    public int NumJewelsInStones(string jewels, string stones)
    {
        char[] jewelArray = jewels.ToCharArray();
        Dictionary<char, int> stoneDict = new Dictionary<char, int>();
        int jewelCount = 0;

        foreach (char stone in stones.ToCharArray())
        {
            if (stoneDict.ContainsKey(stone))
            {
                stoneDict[stone]++;
            }
            else
            {
                stoneDict[stone] = 1;
            }
        }

        foreach (char jewel in jewelArray)
        {
            if(stoneDict.TryGetValue(jewel, out int count))
            {
               jewelCount += count;
            }
        }


        //char[] jewelArray = jewels.ToCharArray();
        //char[] stoneArray = stones.ToCharArray();
        //int jewelCount = 0;
        //foreach (char jewel in jewelArray)
        //{
        //    foreach (char stone in stoneArray)
        //    {
        //        if (jewel == stone)
        //        {
        //            jewelCount++;
        //        }
        //    }
        //}
        return jewelCount;
    }
}