namespace practice4;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Enter First Name :");
        // string name = Console.ReadLine();
        // Person p1 = new Person(name);
        // Console.WriteLine(p1.Name);
        // Console.ReadLine();   
        Person[] people = new Person[3];

    
        for( int i= 0 ; i < people.Length ; i ++)
        {
            Console.WriteLine(" Enter a Person Name ");
            string name = Console.ReadLine();
            people[i] = new Person(name);
        }
        foreach(Person p in people)
        {
            Console.WriteLine( $" Hello! My name {p.Name}");
        }
        
    }
}


public class Person 
{
    public string Name { get; set;}

   public Person(string name)
   {
    Name = name;
   }
}