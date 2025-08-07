public class XMLCreator : ReaderFactory
{
    public override IWeatherReader CreateReader()
    {
        return new XML();
    }
}
