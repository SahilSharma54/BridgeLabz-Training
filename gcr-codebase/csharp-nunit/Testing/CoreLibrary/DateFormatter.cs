using System;
using System.Globalization;

public class DateFormatter
{
    public string FormatDate(string input)
    {
        string[] formats = { "yyyy-MM-dd", "yyyy/MM/dd" };

        DateTime date = DateTime.ParseExact(
            input,
            formats,
            CultureInfo.InvariantCulture,
            DateTimeStyles.None
        );

        return date.ToString("dd/MM/yyyy");
    }
}
