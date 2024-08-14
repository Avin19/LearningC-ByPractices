// See https://aka.ms/new-console-template for more information
public class Developer : Employee
{
    public Developer(string _name, int _salary)
    {
        Name = _name;
        Salary = _salary;
    }

    public override void Work()
    {
        System.Console.WriteLine($" {Name} and you are Developer");
    }
}