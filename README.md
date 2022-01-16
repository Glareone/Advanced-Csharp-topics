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
  
Example is here:

### Async void is BAD
* in progress

### Prefer Task.FromResult over Task.Run
* Do not waste your resources without the reason
* in progress

### Avoid .Result and .Wait at all
* Information regarding synchronization context and potential issues
* in progress


