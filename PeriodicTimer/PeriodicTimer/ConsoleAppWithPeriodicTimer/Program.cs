// See https://aka.ms/new-console-template for more information

using ConsoleAppWithPeriodicTimer;

Console.WriteLine("Press any button to start task");
Console.ReadKey();

// run task each second
var task = new BackgroundTask(TimeSpan.FromMilliseconds(1000));
task.Start();

Console.WriteLine("Press any button to stop the background task");
Console.ReadKey();

await task.StopAsync();