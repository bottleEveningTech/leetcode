public class Solution
{
    public string AddBinary(string a, string b)
    {
        int carry = 0;
        int l1 = a.Length;
        int l2 = b.Length;

        if (l1 < l2)
        {
            return AddBinary(b, a);
        }

        char[] sum = new char[l1 + 1];

        int j = l2 - 1;
        for (int i = l1 - 1; i >= 0; i--)
        {
            int bit1 = a[i] - '0';
            int bitSum = bit1 + carry;

            if (j >= 0)
            {
                bitSum += b[j] - '0';
                j--;
            }

            int resBit = bitSum % 2;
            carry = bitSum / 2;

            sum[i + 1] = (char)(resBit + '0');
        }

        if (carry == 1)
        {
            sum[0] = '1';
            return new string(sum);
        }
        else
        {
            return new string(sum, 1, l1);
        }
    }
}
