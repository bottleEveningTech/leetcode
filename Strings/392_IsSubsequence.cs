public partial class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        var sLength = s.Length;
        var tLength = t.Length;
        if (sLength == tLength)
        {
            return string.Equals(s, t);
        }
        if (sLength > tLength || tLength == 0)
        {
            return false;
        }
        if (sLength == 0)
        {
            return true;
        }
        var sIndex = 0;
        for (int i = 0; i < tLength; i++)
        {
            if (s[sIndex] != t[i])
            {
                continue;
            }
            sIndex++;
            if (sIndex != sLength)
            {
                continue;
            }
            return true;
        }
        return false;
    }
}