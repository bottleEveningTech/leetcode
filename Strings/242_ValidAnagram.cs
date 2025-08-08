public partial class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if(t.Length != s.Length)
        {
            return false;
        }
        char[] sChar = s.ToCharArray();
        char[] tChar = t.ToCharArray();
        return tChar.OrderBy(x => x).SequenceEqual(sChar.OrderBy(x=> x));
    }
}