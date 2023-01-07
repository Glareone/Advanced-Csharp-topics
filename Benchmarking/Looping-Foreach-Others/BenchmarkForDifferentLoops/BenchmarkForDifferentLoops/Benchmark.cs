using BenchmarkDotNet.Attributes;

namespace BenchmarkForDifferentLoops;

[MemoryDiagnoser(false)]
public class Benchmark
{
    private static readonly Random Random = new (12345);
    
    private List<int> _collection;

    [Params(100, 100_000, 1_000_000)] 
    public int _size { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        _collection = Enumerable.Range(1, _size).Select(x => Random.Next()).ToList();
    }

    [Benchmark]
    public void For()
    {
        for (var i = 0; i < _size; i++)
        {
            var item = _collection[i];
        }
    }

    [Benchmark]
    public void Foreach()
    {
        foreach (var item in _collection)
        {
            var selectedItem = item;
        }
    }

    [Benchmark]
    public void ForeachLinq()
    {
        _collection.ForEach(x =>
        {
            var item = x;
        });
    }

    [Benchmark]
    public void PlinqForeach()
    {
        Parallel.ForEach(_collection, x =>
        {
            var item = x;
        });
    }

    [Benchmark]
    public void AsParallelForAll()
    {
        _collection.AsParallel().ForAll(x =>
        {
            var item = x;
        });
    }
    
    
}