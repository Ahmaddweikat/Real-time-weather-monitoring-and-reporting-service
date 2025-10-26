public class SnowBot : IBot
{
    private readonly Data _data;
    private readonly BotConfig _config;
    public SnowBot(Data data, BotConfig config)
    {
        _data = data;
        _config = config;
    }
    public void Activate()
    {
        if (_config.SnowBot.enabled && _data.Temperature < _config.SnowBot.temperatureThreshold)
        {
            Console.WriteLine("SnowBot activated!");
            Console.WriteLine($"SnowBot: {_config.SnowBot.message}");
        }
    }
}