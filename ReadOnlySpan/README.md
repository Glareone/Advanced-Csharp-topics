## System.Span
Span<T> (earlier known as Slice) is a value type introduced in C# 7.2 and .NET Core 2.1 with almost zero overhead. It provides a type-safe way to work with a contiguous block of memory such as:

* Arrays and subarrays
* Strings and substrings
* Unmanaged memory buffers

#### Great article about Span and ReadOnlySpan:
https://www.codemag.com/Article/2207031/Writing-High-Performance-Code-Using-SpanT-and-MemoryT-in-C

#### How span is organized inside:
https://github.com/dotnet/corefx/blob/master/src/Common/src/CoreLib/System/Span.cs

#### My little code example to show the essential idea of ReadOnlySpan:
[ReadOnlySpan](https://github.com/Glareone/C-Advices/tree/main/ReadOnlySpan/Repo/ReadOnlySpanDemonstration/ReadOnlySpanDemonstration/SubstringWithSpanAndWithout.cs)

#### The following are the characteristics of Span<T> at a glance:

* Value type
* Low or zero overhead
* High performance
* Provides memory and type safety


#### You can use Span with any of the following:

* Arrays
* Strings
* Native buffers 

#### The list of types that can be converted to Span<T> are:

* Arrays
* Pointers
* IntPtr
* stackalloc

#### You can convert all of the following to ReadOnlySpan<T>:

* Arrays
* Pointers
* IntPtr
* stackalloc
* string

## System.ReadOnlySpan
This represents a type-safe and memory-safe read-only representation of an arbitrary contiguous area of memory.

## ReadOnlySpan vs String. Benchmark.
![image](https://user-images.githubusercontent.com/4239376/210281651-a0b15bb3-24e2-42e6-9b06-963d84b380ad.png)
