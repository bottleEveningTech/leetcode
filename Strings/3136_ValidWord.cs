public partial class Solution
{
    public bool IsValid(string word)
    {
        if(word.Length < 3)
        {
            return false;
        }
        var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u',
                                          'A', 'E', 'I', 'O', 'U' };
        bool containsVowel = false;
        bool containsConsonant = false;
        foreach(char c in word)
        {
            if (char.IsLetter(c))
            {
                if(vowels.Contains(c))
                {
                    containsVowel = true;
                }
                else
                {
                    containsConsonant = true;
                }
            }
            else if (!char.IsDigit(c))
            {
                return false;
            }
        }

        return containsVowel && containsConsonant;
    }
}