public class SunBot : IBot
{
    private readonly Data _data;
    private readonly BotConfig _config;
    public SunBot(Data data, BotConfig config)
    {
        _data = data;
        _config = config;
    }
    public void Activate()
    {
        if (_config.SunBot.enabled && _data.Temperature > _config.SunBot.temperatureThreshold)
        {
            Console.WriteLine("SunBot activated!");
            Console.WriteLine($"SunBot: {_config.SunBot.message}");
        }
    }
}