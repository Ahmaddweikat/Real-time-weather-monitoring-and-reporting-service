using System.Xml.Serialization;

[XmlRoot("WeatherData")]
public class Data
{
    public string Location { get; set; } = string.Empty;
    public double Temperature { get; set; } = 0.0;
    public double Humidity { get; set; } = 0.0;

    public Data() { }
    public Data(string location, double temperature, double humidity)
    {
        Location = location;
        Temperature = temperature;
        Humidity = humidity;
    }
}