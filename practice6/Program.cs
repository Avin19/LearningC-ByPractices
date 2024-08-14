Console.WriteLine("Hello, World!");
Person p = new Person
{
    Name = "Avinash",
    Age = 32,
    Gender = PersonType.Male,
};
p.Introduce();
Person p2 = new Person("Yadav", 32, PersonType.Male);
p2.Introduce();

/*
1. Classes and Objects
Create a class Person with properties Name, Age, and Gender. 
Write a method Introduce() that prints a simple introduction. 
Instantiate two Person objects and call their Introduce() method.

*/