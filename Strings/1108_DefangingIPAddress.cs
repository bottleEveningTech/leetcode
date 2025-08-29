using System.Text;

public partial class Solution
{
    public string DefangIPaddr(string address)
    {
       StringBuilder sb = new StringBuilder();
        foreach(char c in address)
        {
            if(c == '.')
            {
                sb.Append("[.]");
            }
            else
            {
                sb.Append(c);
            }
        }
        return sb.ToString();
    }
}