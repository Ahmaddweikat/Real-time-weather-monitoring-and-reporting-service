public class UserInput
{
    public static string GetInput(string prompt)
    {
        Console.WriteLine(prompt);
        return Console.ReadLine() ?? string.Empty;
    }
}
