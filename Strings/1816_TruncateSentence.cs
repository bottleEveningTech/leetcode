using System.Text;

public partial class Solution
{
    public string TruncateSentence(string s, int k)
    {
        string[] words = s.Split(' ');
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i< k; i++)
        {
            sb.Append(words[i]);
            if(i != k - 1)
            {
                sb.Append(" ");
            }
        }
        return sb.ToString();
    }
}