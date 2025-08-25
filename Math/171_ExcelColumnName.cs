public partial class Solution
{
    public int TitleToNumber(string columnTitle)
    {
        int columnTitleNumber = 0;
        //alphabetIndex * pow(26, position in column name)
        for (int i = 0; i < columnTitle.Length; i++)
        {
            int power = columnTitle.Length - (i + 1);
            int alphaValue = AlphaValue(columnTitle[i]);
            int positionalValue = (int)(alphaValue * Math.Pow(26, power));
            columnTitleNumber += positionalValue;
        }

        return columnTitleNumber;
    }

    static int AlphaValue(char letter)
    {
        return letter - 'A' + 1;
    }

}