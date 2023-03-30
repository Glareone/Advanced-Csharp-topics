namespace PeriodicTimer;
using System.Threading;

public class RepeatingServiceWithPeriodicTimer: BackgroundService
{
    private readonly PeriodicTimer _timer = new(TimeSpan.FromMilliseconds(1000));
    private readonly ILogger<RepeatingServiceWithPeriodicTimer> _logger;

    public RepeatingServiceWithPeriodicTimer(ILogger<RepeatingServiceWithPeriodicTimer> logger)
    {
        _logger = logger;
    }


    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (await _timer.WaitForNextTickAsync(stoppingToken) && !stoppingToken.IsCancellationRequested)
        {
            await DoWorkAsync();
            _logger.LogTrace("operation completed");
        }
    }
    
    private static async Task DoWorkAsync()
    {
        Console.WriteLine(DateTime.Now.ToString("O"));
        await Task.Delay(300);
    }
}