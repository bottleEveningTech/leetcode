public partial class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        char[] charsToCheck = ransomNote.ToCharArray();
        foreach (char c in magazine)
        {
            if (charsToCheck.Contains(c))
            {
                int index = Array.IndexOf(charsToCheck, c);
                charsToCheck[index] = '1';
            }
        }
        if(charsToCheck.All(c => c == '1'))
        {
            return true;
        }
        return false;
    }
}