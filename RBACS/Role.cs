
/*
3. Designing a Role-Based Access Control System
Task: Create a role-based access control system where different roles have different permissions.
Implement role inheritance and role-specific behaviors.
Requirements:
Create an abstract base class Role with properties like Name and methods AddPermission(), 
RemovePermission(), and HasPermission().
Implement roles such as Admin, Editor, and Viewer, with Admin inheriting from Editor, 
and Editor from Viewer.
Implement a User class with a Role and methods CanPerformAction().
Write a program that demonstrates role-based access control with different users.
*/

public abstract class Role
{
    public string Name { get; set; }
    public HashSet<string> permissionType = new HashSet<string>();


    public void AddPermission(string permission)
    {
        permissionType.Add(permission);
    }
    public void RemovePermission(string permission)
    {
        permissionType.Remove(permission);

    }
    public bool HasPermission(string permission)
    {
        return permissionType.Contains(permission);
    }
}

public class Admin : Editor1
{
    public Admin()
    {
        Name = "Admin";
        AddPermission("Delete");
    }
}
public class Editor1 : Viwer
{
    public Editor1()
    {
        Name = "Editor";
        AddPermission("Write");
    }
}
public class Viwer : Role
{
    public Viwer()
    {
        Name = "Viewer";
        AddPermission("Read");
    }
}