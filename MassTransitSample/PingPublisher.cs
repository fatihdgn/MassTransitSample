using MassTransit;

namespace MassTransitSample;

public class PingPublisher : BackgroundService
{
    private readonly IBus _bus;
    private readonly ILogger<PingPublisher> _logger;

    public PingPublisher(IBus bus, ILogger<PingPublisher> logger)
    {
        _bus = bus;
        _logger = logger;
    }
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            await Task.Yield();

            var keyPressed = Console.ReadKey(true);
            if (keyPressed.Key != ConsoleKey.Escape)
            {
                _logger.LogInformation("Pressed {Button}", keyPressed.Key.ToString());
                await _bus.Publish(new Ping(keyPressed.Key.ToString()));
            }
            await Task.Delay(200);
        }
    }
}
