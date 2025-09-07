using System.Text;

public partial class Solution
{
    public int UniqueMorseRepresentations(string[] words)
    {
        string[] morseCodes = new string[]
        {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
        HashSet<string> transformations = new HashSet<string>();

        foreach (string word in words)
        {
            StringBuilder morseWord = new StringBuilder();
            foreach (char c in word)
            {
                morseWord.Append(morseCodes[c - 'a']);
            }
            transformations.Add(morseWord.ToString());
        }

        return transformations.Count;
    }
}