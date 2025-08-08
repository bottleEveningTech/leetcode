public partial class Solution
{
    public void DuplicateZeros(int[] arr)
    {
        int arrLength = arr.Length;
        for (int i = 0; i < arrLength - 1; i++)
        {
            if (arr[i] == 0)
            {
                for (int j = arrLength - 1; j > i + 1; j--)
                {
                    arr[j] = arr[j - 1];

                }
                arr[i + 1] = 0;
                i++;
            }
        }
    }
}

