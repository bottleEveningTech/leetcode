public partial class Solution
{
    public string ReverseWords(string s)
    {
        string[] words = s.Split(' ');
        for(int i =0; i < words.Length; i++)
        {
            char[] wordChars = words[i].ToCharArray();
            Array.Reverse(wordChars);
            words[i] = new string(wordChars);
        }
        return string.Join(" ", words);

    }
}