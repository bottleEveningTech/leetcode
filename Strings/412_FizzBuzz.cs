public partial class Solution
{
    public IList<string> FizzBuzz(int n)
    {
        string[] arr = new string[n + 1];

        for (int i = 1; i <= n; i++)
        {
            if (i % 15 == 0)
            {
                arr[i] = "FizzBuzz";
            }
            else if (i % 5 == 0)
            {
                arr[i] = "Buzz";
            }
            else if (i % 3 == 0)
            {
                arr[i] = "Fizz";
            }
            else
            {
                arr[i] = i.ToString();

            }
        }
        return arr[1..];
    }
}