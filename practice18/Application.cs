// See https://aka.ms/new-console-template for more information


public class Application
{
    private readonly ILogger _logger;
    public Application(ILogger logger)
    {
        _logger = logger;
    }
    public void Run()
    {
        _logger.Log(" Application is Running");
    }


}