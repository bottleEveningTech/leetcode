public partial class Solution
{
    //public int StrStr(string haystack, string needle)
    //{
    //    for (int i = 0; i <= haystack.Length - needle.Length; i++)
    //    {
    //        for (int j = 0; j < needle.Length; j++)
    //        {
    //            if(haystack[i + j] != needle[j])
    //            {
    //                break;
    //            }
    //            if (j == needle.Length - 1) {
    //                return i;
    //            }
    //        }

    //    }
    //    return -1;
    //}
    public int StrStr(string haystack, string needle)
    {
        if (haystack.Length >= needle.Length)
        {
            List<int> indices = new List<int>();

            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (haystack[i] == needle[0])
                    indices.Add(i);
            }

            for (int i = 0; i < indices.Count; i++)
            {
                string checkString = haystack.Substring(indices[i], needle.Length);
                if (checkString.Equals(needle))
                {
                    return indices[i];
                }
            }
        }
        return -1;
    }
}