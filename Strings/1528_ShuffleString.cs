using System.Text;

public partial class Solution
{
    public string RestoreString(string s, int[] indices)
    {
        StringBuilder sb = new StringBuilder(new string(' ', s.Length));
        for (int i = 0, j = 0; i < s.Length && j < indices.Length; i++, j++) {
            sb[indices[j]] = s[i];
        }
        return sb.ToString();
    }
}