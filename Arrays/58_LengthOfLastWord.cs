using System.Text.RegularExpressions;


public class Solution
{
    public int LengthOfLastWord(string s)
    {
        string[] splitArray = Regex.Replace(s.Trim(), @"\s+", " ").Split(' ');
        return splitArray[splitArray.Length - 1].Length;
    }
}