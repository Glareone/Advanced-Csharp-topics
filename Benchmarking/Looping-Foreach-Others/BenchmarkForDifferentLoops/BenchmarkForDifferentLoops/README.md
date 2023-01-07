# Benchmark

## Benchmarking loops

Here I want to show you the difference between looping methods in terms of performance and memory allocation:  
* For
* Foreach
* Parallel.ForEach
* AsParallel.ForAll

The interesting story here that these methods perform differently with different amount of data in collection.  
* For small collections **For** is a winner. 
* For large collection - depends on processor your app is using. 
    - For Mobile processor with limited amount of cores and freq - For could be the best choice.  
    - For large processors with great amount of cores - Parallel.ForEach could be even faster.