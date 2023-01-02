// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Running;
using ReadOnlySpanDemonstration;


Console.WriteLine("Results:");
var substringWithSpanAndWithout = new SubstringWithSpanAndWithout();
var results = substringWithSpanAndWithout.ShowDayMonthYear();
Console.WriteLine($"day: {results.day}, month: {results.month}, year: {results.year}");
var readOnlySpanResults = substringWithSpanAndWithout.ShowDayMonthYearWithReadOnlySpan();
Console.WriteLine($"day: {readOnlySpanResults.day}, month: {readOnlySpanResults.month}, year: {readOnlySpanResults.year}");
BenchmarkRunner.Run<SubstringWithSpanAndWithout>();
Console.ReadKey();

