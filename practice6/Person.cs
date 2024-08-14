// See https://aka.ms/new-console-template for more information
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public PersonType Gender { get; set; }

    public void Introduce()
    {
        System.Console.WriteLine($"Hi ! My name is {Name} and i am {Age} old , i am {Gender}");
    }
    public Person(string _name, int _age, PersonType _gender)
    {
        Name = _name;
        Age = _age;
        Gender = _gender;
    }
    public Person()
    {

    }
}

public enum PersonType
{
    Male,
    Female,
}