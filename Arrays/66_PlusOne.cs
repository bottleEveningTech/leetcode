public class Solution
{
	public int[] PlusOne(int[] digits)
	{
		int carry = 0;
		if (digits[digits.Length - 1] == 9)
		{
			digits[digits.Length - 1] = 0;
			carry++;
			for (int i = digits.Length - 2; i >= 0; i--)
			{
				if (digits[i] == 9)
				{
					digits[i] = 0;

				}
				else
				{
					digits[i]++;
					carry = 0;
					break;
				}

			}
			if(carry == 1)
			{
				digits = [1, .. digits];
			}
		}
		else
		{
			digits[digits.Length - 1]++;
		}

		return digits;
	}
}