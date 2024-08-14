public class Person
{
    public string Name;
    private int year;
    public int BrithDate { get { return DateTime.Now.Year - year; } set { year = value; } }

    public void Introduce(string name, int _year)
    {
        Name = name;
        year = _year;
        System.Console.WriteLine($"Hi {name} ! I am {BrithDate} old ");
    }

}
