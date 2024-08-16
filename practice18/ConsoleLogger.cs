// See https://aka.ms/new-console-template for more information
public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine("ConsoleLogger :" + message);
    }
}
