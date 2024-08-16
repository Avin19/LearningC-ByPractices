// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
3. Interfaces and Dependency Injection
Define an interface ILogger with a method Log(string message).
Implement two classes FileLogger and ConsoleLogger that implement ILogger.
Create a class Application that takes an ILogger as a dependency through its constructor. 
Write code to demonstrate logging using both FileLogger and ConsoleLogger.
*/

ILogger consoleLogger = new ConsoleLogger();

Application appWithConsoleLogger = new Application(consoleLogger);
appWithConsoleLogger.Run();
string path = "log.txt";
ILogger fileLogger = new FileLogger(path);
Application appWithFileLogger = new Application(fileLogger);
appWithFileLogger.Run();