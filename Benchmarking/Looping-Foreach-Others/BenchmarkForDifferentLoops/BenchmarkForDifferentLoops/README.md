# Benchmark

## Benchmarking loops
Code is here: [Benchmarking Loops - code](https://github.com/Glareone/C-Advices/tree/main/Benchmarking/Looping-Foreach-Others/BenchmarkForDifferentLoops/BenchmarkForDifferentLoops/Benchmark.cs)

Here I want to show you the difference between looping methods in terms of performance and memory allocation:  
* for
* foreach
* Linq ForEach
* Parallel.ForEach
* AsParallel.ForAll

The interesting story here that these methods perform differently with different amount of data in collection.  
* For small collections **For** is a winner. 
* For large collection - depends on processor your app is using. 
    - For Mobile processor with limited amount of cores and freq - For could be the best choice.  
    - For large processors with great amount of cores - Parallel.ForEach could be even faster.

4 Mobile cores Intel U-type:  
![image](https://user-images.githubusercontent.com/4239376/211153715-44cf5e66-18e9-4892-8bde-9969800c3e9b.png)  
  
  
16 Core processor:  
![image](https://user-images.githubusercontent.com/4239376/211153690-188fdb16-7b7e-4870-95ba-b54ac1f29ded.png)  
