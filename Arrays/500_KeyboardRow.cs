public partial class Solution
{
	public string[] FindWords(string[] words)
	{
		char[] firstRow = "qwertyuiop".ToArray();
		char[] secondRow = "asdfghjkl".ToArray();
		char[] thirdRow = "zxcvbnm".ToArray();

		List<string> result = new List<string>();
		foreach (string word in words)
		{
				var tempWords = word.ToLower();
				if (tempWords.All(c => firstRow.Contains(c))
				|| tempWords.All(c => secondRow.Contains(c))
				|| tempWords.All(c => thirdRow.Contains(c)))
				{
					result.Add(word);
				}
		}
		return result.ToArray();
	}
}