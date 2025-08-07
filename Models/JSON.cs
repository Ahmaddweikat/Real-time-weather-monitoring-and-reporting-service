using System.Text.Json;

public class JSON : IWeatherReader
{
    public Data ReadWeather(string input)
    {
        try
        {
            Data? data = JsonSerializer.Deserialize<Data>(input);
            if (data == null || string.IsNullOrWhiteSpace(data.Location))
                throw new Exception(Messages.InvalidJsonMessage);
            Console.WriteLine($"Location: {data.Location}, Temperature: {data.Temperature}, Humidity: {data.Humidity}");
            return data;
        }
        catch
        {
            Console.WriteLine(Messages.InvalidJsonMessage);
            return new Data();
        }
    }
}