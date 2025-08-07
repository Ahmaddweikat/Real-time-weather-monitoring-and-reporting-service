public abstract class ReaderFactory
{
    public abstract IWeatherReader CreateReader();

    public Data GetFactory(string readerType)
    {
        IWeatherReader factory = CreateReader();
        return factory.ReadWeather(readerType);
    }
}