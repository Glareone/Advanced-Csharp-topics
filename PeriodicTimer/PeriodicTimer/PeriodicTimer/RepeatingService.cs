namespace PeriodicTimer;

public sealed class OutdatedRepeatingService: BackgroundService
{
    private readonly ILogger<OutdatedRepeatingService> _logger;

    public OutdatedRepeatingService(ILogger<OutdatedRepeatingService> logger)
    {
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            await DoWorkAsync();
            _logger.LogTrace("operation completed");
            await Task.Delay(1000, stoppingToken);
        }
    }

    private static async Task DoWorkAsync()
    {
        Console.WriteLine(DateTime.Now.ToString("O"));
        await Task.Delay(300);
    }
}