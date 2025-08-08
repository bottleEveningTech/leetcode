public partial class Solution
{
	public bool HalvesAreAlike(string s)
	{
		string modString = s.ToLower();
		int midString = modString.Length / 2;
		string s1 = modString.Substring(0, midString);
		string s2 = modString.Substring(midString);

		if (VowelNumber(s1) == VowelNumber(s2))
		{
			return true;
		}
		return false;
	}

	private int VowelNumber(string s)
	{
		char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
		int count = 0;
		for (int i = 0; i < s.Length; i++)
		{
			if (vowels.Contains(s[i]))
			{
				count++;
			}
		}
		return count;
	}
}