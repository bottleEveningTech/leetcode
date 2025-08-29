public partial class Solution
{
    public char FindTheDifference(string s, string t)
    {
       Dictionary<char, int> freqList = new Dictionary<char, int>();

        foreach(char c in s)
        {
            if (!freqList.ContainsKey(c))
            {
                freqList[c] = 0;
            }
            else
            {
                freqList[c]++;
            }

        }

        foreach (char c in t)
        {
            if(!freqList.ContainsKey(c) || freqList[c] < 0)
            {
                return c;
            }
            else
            {
                freqList[c]--;
            }

        }

        return ' ';
    }
}