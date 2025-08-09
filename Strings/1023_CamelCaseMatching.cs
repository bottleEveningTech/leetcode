
public partial class Solution
{
    public IList<bool> CamelMatch(string[] queries, string pattern)
    {
        IList<bool> result = new List<bool>();

        foreach (string query in queries)
        {
            result.Add(CheckPattern(query, pattern));
        }
        return result;
    }
    private bool CheckPattern(string query, string pattern)
    {
        int i = 0;
        int j = 0;

        for (i = 0; i < query.Length; i++)
        {
            if(pattern.Length == j)
            {
                break;
            }
            if (char.IsUpper(query[i]))
            {
                if (pattern[j] != query[i])
                {
                    return false;
                }
                else
                {
                    j++;
                }
            }
            else
            {
                if (pattern[j] == query[i])
                {
                    j++;
                }
            }
           
        }
        if (pattern.Length > j)
        {
            return false;
        }
        for (int k = i; k < query.Length; k++)
        {
            if (char.IsUpper(query[k])) { return false; }
        }

        return true;
    }
}