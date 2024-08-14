// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
1. Composition
Create a class Engine with properties like HorsePower and Type. 
Then create a class Car that has a property Engine of type Engine. 
Instantiate a Car object and assign it an Engine object. 
Write a method in Car to display the car's engine details.

*/
Engine e = new Engine
{
    HorsePower = 200,
    Type = 12
};
Car c = new Car(e);
c.CarDetail();