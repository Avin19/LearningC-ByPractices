// See https://aka.ms/new-console-template for more information
public class Manager : Employee
{

    public Manager(string _name, int _salary)
    {
        Name = _name;
        Salary = _salary;
    }
    public override void Work()
    {
        System.Console.WriteLine($" Hi {Name} You are Manager !");
    }
}