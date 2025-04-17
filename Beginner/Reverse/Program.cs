// See https://aka.ms/new-console-template for more information
using System;
using System.Text;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the String that you want to reverse !");
        string reverseStr = Console.ReadLine();
        Console.WriteLine(reverseStr.Length);
        StringBuilder str = new StringBuilder();
        for (int i = 0; i < reverseStr.Length; i++)
        {
            int x = reverseStr.Length - 1;
            str.Append(reverseStr[x - i]);
        }
        Console.WriteLine(str);
    }
}
