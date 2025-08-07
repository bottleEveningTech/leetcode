public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        if(strs.Length == 1)
        {
            return [strs.ToList()];
        }

        Dictionary<int, List<string>> groupsByLength = new Dictionary<int, List<string>>();
        IList<IList<string>> result = new List<IList<string>>();


        foreach (string str in strs)
        {
            int length = str.Length;

            if(!groupsByLength.ContainsKey(length))
            {
                groupsByLength[length] = new List<string>();
            }
            groupsByLength[length].Add(str);
        }

        foreach (var kvp in groupsByLength)
        {
            int length = kvp.Key;
            List<string> sameLengthStrings = kvp.Value;

            var anagramMap = sameLengthStrings.GroupBy(x=> new string(x.OrderBy(c => c).ToArray()));

            foreach(var group in anagramMap)
            {
                List<string> groupList = group.ToList();
                if(groupList.Count > 1)
                {
                    result.Add(groupList);
                }
                else
                {
                    result.Add(new List<string> { groupList[0] });
                }
            }
        }
        return result;
    }
}