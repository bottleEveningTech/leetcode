public partial class Solution
{
    public string[] UncommonFromSentences(string s1, string s2)
    {
        var words = (s1 + " " + s2).Split(' ');
        HashSet<string> countOnce = new HashSet<string>();
        HashSet<string> countMore = new HashSet<string>();
       foreach(var word in words)
        {
            if (countOnce.Contains(word))
            {
                countOnce.Remove(word);
                countMore.Add(word);
            }
            else if (countMore.Contains(word))
            {
                continue;
            }
            else
            {
                countOnce.Add(word);
            }
        }

       return countOnce.ToArray();
    }
}