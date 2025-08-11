
    public partial class Solution
    {
        public bool IsPalindrome(int x)
        {
            if((x < 0) || (x % 10 == 0 && x != 0))
            {
                return false;
            }

            int half = 0;
            int num = x;

            while( num > half)
            {
                half = half * 10 + num % 10;
                num = num / 10;
            }

            return (num == half) || (num == half / 10);
        }
    }



