# Advanced C# topics and pieces of advice.
In this repository I will try to explain good concepts regarding Async, regarding Logging and so on.

Covered topics  
&#9745; [Async](https://github.com/Glareone/C-Advices/tree/main/Async/Async_Mistakes)  
&#9744; Logging  
&#9744; Nullable Reference Types   
&#9745; Worker (CPU-bound) & Completion (I\O-bound) Threads  [Worker & CompletionThreads.pptx](https://github.com/Glareone/Advanced-C-topics-and-advices/files/8886222/Worker.CompletionThreads.pptx)  
&#9744; GC, IDisposable, and Finalizer (in progress) GC and related materials are here: [GC Materials](https://github.com/Glareone/C-Advices/tree/main/GC,%20IDisposable,%20Finalizer)  
&#9745; [ReadOnlySpan](https://github.com/Glareone/C-Advices/tree/main/ReadOnlySpan), **ref struct** and how to not allocate extra memory in heap   
&#9744; PeriodicTimer. Proper timer which takes into account when new task starts and ends  
&#9744; Delegates. Delegates use cases in C#10  
&#9744; Benchmarks in Dotnet (Could be found in ReadOnlySpan repo)  
  - [Loops](https://github.com/Glareone/C-Advices/tree/main/Benchmarking/Looping-Foreach-Others/BenchmarkForDifferentLoops/BenchmarkForDifferentLoops)  
  - [ReadOnlySpan](https://github.com/Glareone/C-Advices/tree/main/ReadOnlySpan/Repo) 

## Async
Async materials are here: [Async materials](https://github.com/Glareone/C-Advices/tree/main/Async/Async_Mistakes)

## Logging

## GC, IDisposable, Finalizer
GC and related materials are here: [GC Materials](https://github.com/Glareone/C-Advices/tree/main/GC,%20IDisposable,%20Finalizer)  
.Netos slides\goodies: [https://goodies.dotnetos.org](https://goodies.dotnetos.org/)  

## Nullable Reference Types

## Console App with Generic Host. Running application from pipeline.

**Allows to run any Tasks and use Host services lifetime. Might be useful to run EF DBMigrations from Pipeline or from another place**
https://dfederm.com/building-a-console-app-with-.net-generic-host/
