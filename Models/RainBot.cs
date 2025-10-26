public class RainBot : IBot
{
    private readonly Data _data;
    private readonly BotConfig _config;

    public RainBot(Data data, BotConfig config)
    {
        _data = data;
        _config = config;
    }

    public void Activate()
    {
        if (_config.RainBot.enabled && _data.Humidity > _config.RainBot.humidityThreshold)
        {
            Console.WriteLine("RainBot activated!");
            Console.WriteLine($"RainBot: {_config.RainBot.message}");
        }
    }
}