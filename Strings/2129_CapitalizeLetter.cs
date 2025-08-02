public class Solution
{
    public string CapitalizeTitle(string title)
    {
        string[] modifiedTitle = title.Split(' ');
        for(int i = 0; i< modifiedTitle.Length; i++)
        {
            //string word = modifiedTitle[i] = modifiedTitle[i].ToLower();
            //if(word.Length > 2)
            //{
            //    char[] chars = word.ToCharArray();
            //    chars[0] = char.ToUpper(chars[0]);
            //    modifiedTitle[i] = new string(chars);
            //}
            modifiedTitle[i] = modifiedTitle[i].ToLower();
            if (modifiedTitle[i].Length > 2)
            {
                modifiedTitle[i] = char.ToUpper(modifiedTitle[i][0]) + modifiedTitle[i].Substring(1);

            }
        }
        return string.Join(" ", modifiedTitle);
    }
}