
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


public class User
{
    public Role role { get; set; }
    

    public void CanPerformAction()
    {

    }
}