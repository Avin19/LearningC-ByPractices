// See https://aka.ms/new-console-template for more information

public class Department
{
    public string Name { get; set; }
    public Department(string _name)
    {
        Name = _name;
    }
    public List<Employee> Employees = new List<Employee>();

    public void AddEmployeeToDepartment(Employee employee)
    {
        Employees.Add(employee);
    }
    public void Display()
    {
        System.Console.WriteLine(Name);
        foreach (Employee emp in Employees)
        {
            System.Console.WriteLine($"Employee {emp.Name} is on this {emp.Position}");
        }
    }
}

