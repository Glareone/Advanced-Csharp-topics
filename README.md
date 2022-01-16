# C Advices.
In this repository I will try to explain good concepts regarding Async, regarding Logging and so on.

Covered topics  
&#9744; Async  
&#9744; Logging  
&#9744; Nullable Reference Types   

## Async
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

Example is here: [https://github.com/Glareone/C-Advices/blob/899ad6a8e8e912d201302ecaa8cdd5c1b72b73f2/Async/Async_Mistakes/Async_Mistakes/OnceAsyncAlwaysAsync/Program.cs#L15](Once_Async_Always_Async)

### Async void is BAD
* in progress

### Prefer Task.FromResult over Task.Run
* Do not waste your resources without the reason
* in progress

### Avoid .Result and .Wait at all
* Information regarding synchronization context and potential issues
* in progress


