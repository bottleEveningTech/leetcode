using System.Text;

public partial class Solution
{
    public string RestoreString(string s, int[] indices)
    {
        char[] chars = new string(' ', s.Length).ToCharArray();
        //StringBuilder sb = new StringBuilder(new string(' ', s.Length));
        for (int i = 0, j = 0; i < s.Length && j < indices.Length; i++, j++) {
            chars[indices[j]] = s[i];
        }
        //return sb.ToString();
        return new string(chars);
    }
}