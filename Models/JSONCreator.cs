public class JSONCreator : ReaderFactory
{
    public override IWeatherReader CreateReader()
    {
        return new JSON();
    }
}