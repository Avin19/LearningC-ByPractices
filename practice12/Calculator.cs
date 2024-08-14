// See https://aka.ms/new-console-template for more information
/*

Create a class Calculator with overloaded methods
 Add() to add two, three, or four integers. 
Test each version of the Add() method by calling
 it with different numbers of arguments.

*/

public class Calculator
{
    public int Add(int x, int y)
    {
        return x + y;
    }
    public int Add(int x, int y, int z)
    {
        return x + y + z;
    }
    public int Add(int x, int y, int z, int w)
    {
        return x + y + z + w;
    }
}