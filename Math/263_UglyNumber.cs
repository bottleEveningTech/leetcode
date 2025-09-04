public partial class Solution
{
    public bool IsUgly(int n)
    {
        if(n == 1)
        {
            return true;
        }

        if(n <= 0)
        {
            return false;
        }
        List<int> primes = new List<int>();
        var allowed = new HashSet<int> { 2, 3, 5 };
        while (n % 2 == 0)
        {
            primes.Add(2);
            n = n / 2;
        }

        for(int i = 3; i * i <= n; i = i + 2)
        {
            while(n % i == 0)
            {
                primes.Add(i);
                n = n / i;
            }
        }

        if(n > 1)
        {
          primes.Add(n);
        }

        if(primes.Any(x => !allowed.Contains(x))){
            return false;
        }
        return true;
    }
}