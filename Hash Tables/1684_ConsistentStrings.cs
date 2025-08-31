public partial class Solution
{
    public int CountConsistentStrings(string allowed, string[] words)
    {

        HashSet<char> allowedChars = new HashSet<char>(allowed);
        int count = 0;
        foreach (var word in words)
        {
            HashSet<char> setWord = new HashSet<char>(word);
            bool isConsistent = true;
            foreach (char c in setWord)
            {
                if (!allowedChars.Contains(c))
                {
                    isConsistent = false;
                    break;
                }
            }
            if (isConsistent)
            {
                count++;
            }
        }
        return count;
    }
}