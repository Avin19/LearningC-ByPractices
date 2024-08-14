// See https://aka.ms/new-console-template for more information
/*

Create a base class Employee with properties Name, Salary, and a method Work(). 
Create two derived classes Manager and 
Developer that override the Work() method to provide specialized behavior.


*/


public class Employee
{

    public string Name { get; set; }
    public int Salary { get; set; }

    public virtual void Work()
    {
        System.Console.WriteLine($" Name : {Name}  ");
    }
}