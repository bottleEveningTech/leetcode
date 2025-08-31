public partial class Solution
{
    public int CountCharacters(string[] words, string chars)
    {
        Dictionary<char, int> charFreqCount = new Dictionary<char, int>();
        int count = 0;
        foreach (char c in chars)
        {
            if (charFreqCount.ContainsKey(c))
            {
                charFreqCount[c]++;
            }
            else
            {
                charFreqCount[c] = 1;
            }
        }

        foreach (string word in words)
        {
            Dictionary<char, int> tempCharFreqCount = new Dictionary<char, int>(charFreqCount);
            bool isGood = true;
            foreach (char c in word)
            {
                if (!tempCharFreqCount.ContainsKey(c) || tempCharFreqCount[c] == 0)
                {
                    isGood = false;
                    break;
                }
                else
                {
                    tempCharFreqCount[c]--;
                }
            }
            if (isGood)
            {
                count += word.Length;
            }

        }
        return count;
    }
}