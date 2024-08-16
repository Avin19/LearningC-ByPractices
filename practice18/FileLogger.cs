// See https://aka.ms/new-console-template for more information


public class FileLogger : ILogger
{
    private string _fileName;

    public FileLogger(string fileName)
    {
        _fileName = fileName;
    }
    public void Log(string message)
    {
        Console.WriteLine(_fileName + " FileLogger :" + message);
    }

}
