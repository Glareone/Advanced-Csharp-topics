using BenchmarkDotNet.Attributes;

namespace ReadOnlySpanDemonstration;

[MemoryDiagnoser]
public class SubstringWithSpanAndWithout
{
    private static string _date = "22 10 2023";

    [Benchmark]
    public (int day, int month, int year) ShowDayMonthYear()
    {
        var day = int.Parse(_date.Substring(0, 2));
        var month = int.Parse(_date.Substring(3, 2));
        var year = int.Parse(_date.Substring(6, 4));

        return (day, month, year);
    }
    
    [Benchmark]
    public (int day, int month, int year) ShowDayMonthYearWithReadOnlySpan()
    {
        ReadOnlySpan<char> spanDate = _date;
        var day = int.Parse(spanDate.Slice(0, 2));
        var month = int.Parse(spanDate.Slice(3, 2));
        var year = int.Parse(spanDate.Slice(6, 4));

        return (day, month, year);
    }
}