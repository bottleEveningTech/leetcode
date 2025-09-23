﻿public partial class Solution
{
    public bool ValidMountainArray(int[] arr)
    {
        int n = arr.Length;
        if (n < 3)
        {
            return false;
        }

        int i = 0;
        while (i + 1 < n && arr[i + 1] > arr[i])
        {
            i++;
        }

        if (i == 0 || i == n - 1)
        {
            return false;
        }

        while (i + 1 < n && arr[i + 1] < arr[i])
        {
            i++;
        }

        return i == n - 1;
    }
}