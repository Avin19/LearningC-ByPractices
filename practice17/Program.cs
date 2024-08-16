// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


/* 
Design a class Department with properties 
Name and a list of Employee objects. 
Create an Employee class with properties Name and Position. 
Demonstrate how to add employees to a department and list all 
employees in a department.
*/


Employee employee1 = new Employee("Avinash", "Game Developer");
Employee employee2 = new Employee("Yadav", " Tester");
Employee employee3 = new Employee("Amit", " Army");


Department D = new Department("Developers");
D.AddEmployeeToDepartment(employee1);
D.AddEmployeeToDepartment(employee2);
D.AddEmployeeToDepartment(employee3);
D.Display();

Department B = new Department("Marketing");
B.AddEmployeeToDepartment(employee1);
B.AddEmployeeToDepartment(employee3);

B.Display();