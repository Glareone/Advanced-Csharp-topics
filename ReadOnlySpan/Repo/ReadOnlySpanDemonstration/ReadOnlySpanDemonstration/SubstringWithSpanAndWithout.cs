namespace ReadOnlySpanDemonstration;

public class SubstringWithSpanAndWithout
{
    private static string _date = "22 10 2023";

    public static void ShowDayMonthYear()
    {
        var day = _date.Substring(0, 2);
        var month = _date.Substring(3, 2);
        var year = _date.Substring(6, 4);
        
        Console.WriteLine($"day: {day}");
        Console.WriteLine($"month: {month}");
        Console.WriteLine($"year: {year}");
    }
    
    public static void ShowDayMonthYearWithReadOnlySpan()
    {
        ReadOnlySpan<char> spanDate = _date;
        var day = spanDate.Slice(0, 2);
        var month = spanDate.Slice(3, 2);
        var year = spanDate.Slice(6, 4);
        
        Console.WriteLine($"span day: {day}");
        Console.WriteLine($"span month: {month}");
        Console.WriteLine($"span year: {year}");
    }
}