using System;
using System.Text;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(" Check if a Number is a Palindrome");
        string str = Console.ReadLine();
        StringBuilder strbuild = new StringBuilder();
        for (int i = 0; i < str.Length; i++)
        {
            int x = str.Length - 1;
            strbuild.Append(str[x - i]);

        }
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == strbuild[i])
            {
                Console.WriteLine("It is Palindrome");
            }
            else
            {
                Console.WriteLine("It is not Palindrome");
                break;
            }
        }
    }
}