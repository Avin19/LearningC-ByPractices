// See https://aka.ms/new-console-template for more information
/*

Define a class Counter with a static field count that tracks 
the number of Counter objects created. 
Add a method to display the current count. 
Instantiate several Counter objects and display 
the count after each instantiation.

*/

public class Counter
{
    public static int count = 0;

    public Counter()
    {
        count++;
        Display();
    }

    public void Display()
    {
        System.Console.WriteLine(count);
    }

}