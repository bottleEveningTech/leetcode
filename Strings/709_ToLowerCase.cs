using System.Text;

public partial class Solution
{
    public string ToLowerCase(string s)
    {
        StringBuilder result = new StringBuilder();
        foreach (char c in s)
        {
            if(c >= 65 && c <= 90)
            {
                result.Append((char)(c + 32));
            }
            else
            {
                result.Append(c);
            }
        }
        return result.ToString();
        //return s.ToLower(); Using built-in method
    }
}