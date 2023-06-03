using System.Dynamic;
using BenchmarkDotNet.Attributes;

namespace Dynamic.Performance;

[MemoryDiagnoser(false)]
public class BenchmarkingDynamicAllocation
{
    private readonly Person[] _items =
    {
        new()
        {
         FullName = "Alex",
         DateOfBirth = new DateOnly(1989,1,1)
        }
    };
      
    // Collection using Generic Person
    [Benchmark]
    public PagedResponse<Person> PagedResponse()
    {
        return new PagedResponse<Person>
        {
            Items = _items,
            PageNumber = 1,
            PageSize = 1
        };
    }
    
    // Dynamic Collection using ExpandoObject
    [Benchmark]
    public dynamic DynamicResponse()
    {
        dynamic dynamicResponse = new ExpandoObject();
        dynamicResponse.Items = _items;
        dynamicResponse.PageNumber = 1;
        dynamicResponse.PageSize = 1;
        return dynamicResponse;
    }
}