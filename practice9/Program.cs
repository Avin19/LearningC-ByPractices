using System.Collections.Generic;
using System.Globalization;
Console.WriteLine("Hello, World!");

Gemetry g = new Gemetry();

foreach (IShape s in g.shapes)
{
    s.Draw();
}

public class Gemetry
{

    public List<IShape> shapes = new List<IShape>();

    public Gemetry()
    {
        TestFunct();
    }
    public void TestFunct()
    {
        Circle c = new Circle();
        Square s = new Square();
        Triangle t = new Triangle();
        shapes.Add(c);
        shapes.Add(s);
        shapes.Add(t);

    }


}