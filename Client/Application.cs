public class Application
{
    public static void Initialize()
    {
        string input = UserInput.GetInput(Messages.InputMessage);

        Data weatherData;

        if (input.TrimStart().StartsWith("{") && input.TrimEnd().EndsWith("}"))
        {
            ReaderFactory jsonCreator = new JSONCreator();
            weatherData = jsonCreator.GetFactory(input);
        }
        else if (input.TrimStart().StartsWith("<") && input.TrimEnd().EndsWith(">"))
        {
            ReaderFactory xmlCreator = new XMLCreator();
            weatherData = xmlCreator.GetFactory(input);
        }
        else
        {
            Console.WriteLine(Messages.ErrorMessage);
            return;
        }

        Console.WriteLine($"Result: Location= {weatherData.Location}, Temperature= {weatherData.Temperature}, Humidity= {weatherData.Humidity}");
    }
}