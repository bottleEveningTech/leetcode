public partial class Solution
{

    private static readonly Dictionary<string, string> MonthMap = new()
            {
                {"Jan", "01"}, {"Feb", "02"}, {"Mar", "03"}, {"Apr", "04"},
                {"May", "05"}, {"Jun", "06"}, {"Jul", "07"}, {"Aug", "08"},
                {"Sep", "09"}, {"Oct", "10"}, {"Nov", "11"}, {"Dec", "12"}
            };

    public string ReformatDate(string date)
    {

        string[] modifiedString = date.Split(' ');

        modifiedString[0] = modifiedString[0].Substring(0, modifiedString[0].Length - 2);
        modifiedString[0] = modifiedString[0].Length == 1 ? ("0" + modifiedString[0]) : modifiedString[0];

        modifiedString[1] = MonthMap[modifiedString[1]];
        //DateTime tempDate = DateTime.ParseExact(modifiedString[1], "MMM", CultureInfo.InvariantCulture);
        //modifiedString[1] = tempDate.ToString("MM");

        return (modifiedString[2] + "-" + modifiedString[1] + "-" + modifiedString[0]);
        //StringBuilder result = new StringBuilder();

    }
}