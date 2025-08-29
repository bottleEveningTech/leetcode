public partial class Solution
{
    public int FirstUniqChar(string s)
    {
        Dictionary<char, int> freqList = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (!freqList.ContainsKey(c))
            {
                freqList[c] = 1;
            }
            else
            {
                freqList[c]++;
            }
        }

        for(int i =0; i < s.Length; i++)
        {
            if(freqList[s[i]] == 1)
            {
                return i;
            }
        }
        return -1;
    }
}