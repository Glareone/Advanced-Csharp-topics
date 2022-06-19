# GC, IDisposable, Finalizer
## Written Materials
[IDisposable, GC, Finalizer.docx](https://github.com/Glareone/Advanced-C-topics-and-advices/files/8903957/IDisposable.GC.Finalizer.docx)  
.Netos slides\goodies: [https://goodies.dotnetos.org](https://goodies.dotnetos.org/)    
[.Net memory Performance Analysis from Maoni, GC Architect](https://github.com/Maoni0/mem-doc/blob/master/doc/.NETMemoryPerformanceAnalysis.md)  
[Dotnetos - Memory Poster](https://goodies.dotnetos.org/files/dotnetos-netmemoryposter.pdf)  
[Dotnetos - Net Memoty Poster - Threads](https://goodies.dotnetos.org/files/dotnetos-netmemoryposter_threads.pdf)  
[Dotnetos - Net Memory Poster - Generations](https://goodies.dotnetos.org/files/dotnetos-netmemoryposter_gens.pdf)  

## Essential part of Dotnetos "GC Internals"
![image](https://user-images.githubusercontent.com/4239376/173689642-493be7b6-1487-40d7-93a8-12747406b44a.png)
![image](https://user-images.githubusercontent.com/4239376/173689739-f8e4f7bb-23a7-47a1-a5b1-db43b42575f4.png)
![image](https://user-images.githubusercontent.com/4239376/173688651-55ae55df-3c19-4e53-ad3b-76a3538ec576.png)

## Object Graph, Mark Phase:

Whole pack of slides are here: [Goodies at dotnetos.org, PDF](https://goodies.dotnetos.org/files/02.%20NET%20GC%20Internals%20-%20Mark%20phase.pdf)

Roots starts from:
1) stack  
2) Registers  
3) static/thread-local static data  
4) finalization queue  
5) inter-generational references ("card", "cards table") (how GC tracks references between generations)  
![image](https://user-images.githubusercontent.com/4239376/174496130-d0fd2047-8e94-4bae-a350-1dbaba7de5ee.png)
After Mark Phase we definitely know which objects are not reachable and now become garbage for us:  
![image](https://user-images.githubusercontent.com/4239376/174496593-520d5d0a-e0b1-4917-a583-764c85716103.png)


Algorithm For .Net specific GC Garbage Collector:
1) Collect the roots into "visit list" (names the mark stack, FIFO)
2) and for each Address (addr) in a stack:  
  a) set pinning flag (sets in a object's HEADER, making this object unmovable in memory for GC, adding "pinned root" to the object) - feasible in C# using ```unsafe { fixed (int *x = &your_instance.local_variable_x) }```
  A pinned object is one that has a set location in memory. Normally the garbage collector will compact the managed heap, which changes the location of the objects in memory. If you have some unmanaged code that refers to some C# object you have created you may want to be able to reference the memory location absolutely. Pinning the object enables you to do this with certainty. More: [pinned in .net](https://www.microsoft.com/en-us/download/details.aspx?id=55984)
  
    b) start traversal (visit other references from this object)
      * Skip already visited objects
      * mark object
      * add mark to Mark Stack




