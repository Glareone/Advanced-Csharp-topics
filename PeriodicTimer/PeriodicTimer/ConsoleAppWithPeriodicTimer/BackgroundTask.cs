namespace ConsoleAppWithPeriodicTimer;

public class BackgroundTask
{
    private Task? _timerTask;
    private readonly PeriodicTimer _timer;
    private readonly CancellationTokenSource _cancellationTokenSource = new();

    public BackgroundTask(TimeSpan interval)
    {
        _timer = new PeriodicTimer(interval);
    }

    private async Task DoWorkAsync()
    {
        try
        {
            while (await _timer.WaitForNextTickAsync(_cancellationTokenSource.Token))
            {
                Console.WriteLine(DateTime.Now.ToString("O"));
            }
        }
        catch(OperationCanceledException)
        {
            
        }
    }

    public void Start()
    {
        _timerTask = DoWorkAsync();
    }

    public async Task StopAsync()
    {
        if (_timerTask is null)
        {
            return;
        }
        
        _cancellationTokenSource.Cancel();
        
        // Await the last invocation of this task (because it might be important drop the last running operation)
        await _timerTask;
        
        _cancellationTokenSource.Dispose();
        
        Console.WriteLine("Task was cancelled");
    } 
}