# Async
### Once Async Always Async
* This means if you somewhere start using async - you should try to use it through your whole flow. It gives you lots of benefits.
* Dont use `.Result` from async method. It `.Net5` it will not block your context, however it's not very efficient.  
  
```csharp
// the incorrect way of calling the async endpoint from the sync context  
var number = repository.GetValueAsync().Result;  
// In .Net 5 most of basics could bee used in Async context with Task.  
// Even Main in console application  
var number_result = await repository.GetValueAsync();  
 ```

Example is here: [https://github.com/Glareone/C-Advices/blob/main/Async/Async_Mistakes/Async_Mistakes/OnceAsyncAlwaysAsync/Program.cs](Once_Async_Always_Async)

### Async void is BAD
* `Async void` blocks your debugging and let your application being crashed without callstack.
Materials & links:  
[Xamarin Example](https://johnthiriet.com/removing-async-void/)  
[Example with classic Task and ContinueWith](https://theburningmonk.com/2012/10/c-beware-of-async-void-in-your-code/)

### Prefer Task.FromResult over Task.Run
* Do not waste your resources without the reason
 
 In the example below in order to return the simple value we use Task.Run:  

```csharp
public async Task<int> GetMultipliedValueAsync(int number)
{
    return await Task.Run(() => number * 2);
}
```
 But behind the scenes Task.Run uses ThreadPool and utilizes the thread and system resources.  

In order to fix that you have several options:
* Transform it into simple `Task.FromResult`:  

```csharp
public async Task<int> GetMultipliedValueAsync2(int number)
{
    return await Task.FromResult(number * 2);
}
```

* Or even more. Use `ValueTask<T>`:  

```csharp
// In C# 7.0 ValueTask was added and it's advantage in not allocating object in a heap as an additional resources.
public async ValueTask<int> GetMultipliedValueAsync3(int number)
{
    return await Task.FromResult(number * 2);
}
```

Problem:  
since Task is a reference type, returning a Task object from an asynchronous method implies allocating the object on the managed heap each time the method is called.

Advantages with `ValueTask<T>`:
* ValueTask<T> improves performance because it doesn’t need heap allocation. 
* It is both easy and flexible to implement. By returning ValueTask<T> instead of Task<T> from an asynchronous method when the result is immediately available, you can avoid the unnecessary overhead of allocation since “T” here represents a structure and a struct in C# is a value type (in contrast to the “T” in Task<T>, which represents a class).

Disadvantages with `ValueTask<T>`:  
* When should I use ValueTask in C#?
Albeit the benefits that ValueTask provides, there are certain trade-offs to using ValueTask in lieu of Task. ValueTask is a value type with two fields, whereas Task is a reference type with a single field. Hence using a ValueTask means working with more data since a method call would return two fields of data in lieu of one. Also, if you await a method that returns a ValueTask, the state machine for that asynchronous method would be larger as well — because it would have to accommodate a struct that contains two fields in lieu of a single reference in the case of a Task.

Additional information regarding ValueTask is here: [Value Task article](https://www.infoworld.com/article/3565433/how-to-use-valuetask-in-csharp.html#:~:text=ValueTask%20is%20a%20value%20type,data%20in%20lieu%20of%20one.)



### Avoid .Result and .Wait at all
* Information regarding synchronization context and potential issues
* in progress


