// See https://aka.ms/new-console-template for more information



public class Car
{
    public Engine Engine { get; set; }

    public Car(Engine engine)
    {
        Engine = engine;
    }
    public void CarDetail()
    {
        System.Console.WriteLine($" Car Engine HorsePower {Engine.HorsePower} , Engine Type V{Engine.Type}");
    }

}