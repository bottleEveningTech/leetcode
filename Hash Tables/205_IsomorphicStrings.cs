public partial class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        if(s.Length != t.Length)
        {
            return false;
        }
        return GetPattern(s) == GetPattern(t);
    }
    private string GetPattern(string str)
    {
        var map = new Dictionary<char, int>();
        var pattern = new List<int>();
        int id = 0;

        foreach (char c in str)
        {
            if (!map.ContainsKey(c))
            {
                map[c] = id++;
            }
            pattern.Add(map[c]);
        }

        return string.Join(",", pattern);
    }

}