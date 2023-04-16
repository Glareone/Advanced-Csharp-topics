# Advanced C# topics and pieces of advice.
In this repository I will try to explain good concepts regarding Async, regarding Logging and so on.

Covered topics  
&#9745; Async
  - Async materials are here: [Async materials](https://github.com/Glareone/C-Advices/tree/main/Async/Async_Mistakes)  
  - Async void pitfalls (in progress)

&#9744; Logging  
&#9745; Nullable Reference Types   
  - [Nullable Reference Types. Article in a Blog](https://thecodeblogger.com/2022/05/26/getting-started-on-nullable-reference-types/)  

&#9744; Validation. Settings Validation  

&#9745; Worker (CPU-bound) & Completion (I\O-bound) Threads  [Worker & CompletionThreads.pptx](https://github.com/Glareone/Advanced-C-topics-and-advices/files/8886222/Worker.CompletionThreads.pptx)  
&#9744; GC, IDisposable, and Finalizer (in progress) GC and related materials are here: 
  - [GC Materials](https://github.com/Glareone/C-Advices/tree/main/GC,%20IDisposable,%20Finalizer)  
  - [Resurrection in .Net, GC Generations](https://medium.com/@vasylsenko/resurrection-in-net-framework-e6c8108e2122)
  - [GC internals by Konrad Kokosa on Youtube](https://www.youtube.com/watch?v=8i1Nv7wGsjk&list=PLpUkQYy-K8Y-wYcDgDXKhfs6OT8fFQtVm)
  - .Netos slides\goodies: [https://goodies.dotnetos.org](https://goodies.dotnetos.org/)  

&#9745; [ReadOnlySpan](https://github.com/Glareone/C-Advices/tree/main/ReadOnlySpan), **ref struct** and how to not allocate extra memory in heap   
&#9745; [PeriodicTimer, modern way how to run background tasks](https://github.com/Glareone/C-Advices/tree/main/PeriodicTimer/PeriodicTimer)  
&#9744; Delegates. Delegates use cases in C#10  
&#9745; Benchmarks in Dotnet (Could be found in ReadOnlySpan repo)  
  - [Benchmark: Loops with Linq, Parallel, and Span](https://github.com/Glareone/C-Advices/tree/main/Benchmarking/Looping-Foreach-Others/BenchmarkForDifferentLoops/BenchmarkForDifferentLoops)  
  - [Benchmark memory: ReadOnlySpan](https://github.com/Glareone/C-Advices/tree/main/ReadOnlySpan/Repo)  
  
&#9744;  Benchmarking WebAPI and GC utilization in it. CQRS Cost. 
  - [Little CQRS + .Net5 project example](https://github.com/Glareone/CQRS-with-MediatR-.Net5)
  - Cost of CQRS. SPOILER: Around 5-8% depends on amount of memory allocated for your container with running application.

&#9744; Data Structures
  - [MIT 6.851. "Advanced Data Structures" Course](https://www.youtube.com/watch?v=T0yzrZL1py0&list=PLUl4u3cNGP61hsJNdULdudlRL493b-XZf)

&#9744; Reflection and its performance in modern C#. Dynamic as "Instead of Reflection"
  - Dynamic in modern C# (in progress)
  - Reflections and its performance in NET8 Preview (in progress)
 
&#9745; Console App with Generic Host. Running application from the pipeline. (useful for DB Migration)

**Allows to run any Tasks and use Host services lifetime. Might be useful to run EF DBMigrations from Pipeline or from another place**
https://dfederm.com/building-a-console-app-with-.net-generic-host/

&#9744; EntityFramework vs Dapper. Improving speed of EntityFramework  (in progress)  
&#9744; Kafka meets .Net6  (in progress)  
&#9745; [GraphQL meets .Net6](https://github.com/Glareone/GraphQL-meets-.Net6)   
