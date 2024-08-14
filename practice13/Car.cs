
/*
Create a base class Vehicle with a virtual method Start(). 
Derive classes Car and Motorcycle that override the Start() 
method with specific implementations. 
Create instances of Car and Motorcycle and call the Start() 
method on each.
*/
public class Car : Vehicle
{
    public override void Start()
    {
        System.Console.WriteLine(" Car is Starting ");
    }
}
