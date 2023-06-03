using System.Dynamic;
using System.Reflection;
using BenchmarkDotNet.Attributes;

namespace Dynamic.Performance;

public class BenchmarkingDynamicMethodCall
{
    private readonly MethodInfo _calculateMethodInfo = typeof(Person).GetMethod(nameof(Person.CalculateAge));
    
    private readonly Person _person = new()
    {
        FullName = "Alex",
        DateOfBirth = new DateOnly(1989, 1, 1)
    };

    private readonly dynamic _dynamicPerson = new Person
    {
        FullName = "Alex",
        DateOfBirth = new DateOnly(1989, 1, 1)
    };

    private readonly dynamic _expandoPerson = getExpandoPerson();

    private static dynamic getExpandoPerson()
    {
        dynamic expandoPerson = new ExpandoObject();
        expandoPerson.FullName = "Alex";
        expandoPerson.DateOfBirth = new DateOnly(1989, 1, 1);
        
        // it's because we would like to avoid Closure and DisplayClass (which gives a little overhead)
        expandoPerson.CalculateAge = new Func<int, int>(year => DateTime.Now.Year - year);
        return expandoPerson;
    }

    [Benchmark]
    public int PersonCalculateAge()
    {
        return _person.CalculateAge();
    }

    [Benchmark]
    public int DynamicCalculateAge()
    {
        return _dynamicPerson.CalculateAge();
    }

    [Benchmark]
    public int ExpandoCalculateAge()
    {
        // it's because we would like to avoid Closure and Displayclass (which gives a little overhead)
        return _expandoPerson.CalculateAge(_expandoPerson.DateOfBirth.Year);
    }

    [Benchmark]
    public int ReflectionCalculateAge()
    {
        return (int)_calculateMethodInfo.Invoke(_person, null)!;
    }
}