using System.Xml.Serialization;

public class XML : IWeatherReader
{
    public Data ReadWeather(string input)
    {
        try
        {
            var serializer = new XmlSerializer(typeof(Data));
            StringReader reader = new StringReader(input);
            Data? data = (Data?)serializer.Deserialize(reader);

            if (data == null || string.IsNullOrWhiteSpace(data.Location))
                throw new Exception(Messages.InvalidXmlMessage);

            Console.WriteLine($"Location: {data.Location}, Temperature: {data.Temperature}, Humidity: {data.Humidity}");
            return data;
        }
        catch
        {
            Console.WriteLine(Messages.InvalidXmlMessage);
            return new Data();
        }
    }
}