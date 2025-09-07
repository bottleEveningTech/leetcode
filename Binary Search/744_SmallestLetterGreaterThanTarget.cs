public partial class Solution
{
    public char NextGreatestLetter(char[] letters, char target)
    {
        //similar to ceil of a number in a sorted array, but we need to return the next greater element

        int start = 0;
        int end = letters.Length - 1;
        char res = letters[0];
        while (start <= end)
        {
            int mid = start + (end - start) / 2;

            if (letters[mid] <= target)
            {
                start = mid + 1;
            }
            else
            {
                res = letters[mid];
                end = mid - 1;
            }
        }
        return res;
    }
}