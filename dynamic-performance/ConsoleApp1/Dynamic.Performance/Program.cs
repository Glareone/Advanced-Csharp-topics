using System.Dynamic;
using BenchmarkDotNet.Running;
using Dynamic.Performance;

// Allocation Benchmark 
BenchmarkRunner.Run<BenchmarkingDynamicAllocation>();

// Benchmarking class method
BenchmarkRunner.Run<BenchmarkingDynamicMethodCall>();
return;

// Simple trivial examples of how we can use dynamic with known type and with ExpandoObject
// we can use dynamic here or just var, but there is a difference what happens behind the scenes
dynamic person = new Person
{
    FullName = "Alex",
    DateOfBirth = new DateOnly(1989,1,1)
};

Console.WriteLine(person.FullName);

// represents dynamic object in which you could add or remove dynamic objects
dynamic expandoPerson = new ExpandoObject();
expandoPerson.FullName = "Alex in expandoObject";
expandoPerson.DateOfBIrth = new DateOnly(1989, 1, 1);

Console.WriteLine(expandoPerson.FullName);

