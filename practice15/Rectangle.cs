// See https://aka.ms/new-console-template for more information
/*
Write a class Rectangle with private fields width and height. 
Implement public properties to get and set these fields, 
with validation to ensure they are positive numbers.
 Add a property Area that calculates the area of the rectangle. 
Instantiate a Rectangle object and display its properties.

*/


using System.Formats.Asn1;

public class Rectangle
{
    private int height;
    private int width;

    public int Height
    {
        get { return height; }
        set
        {
            if (value > 0)
            {
                height = value;
            }

        }
    }
    public int Width
    {
        get { return width; }
        set
        {
            if (value > 0)
            {
                width = value;
            }
        }


    }

    public float Area
    {
        get
        {
            return (float)width * height;
        }
    }

}