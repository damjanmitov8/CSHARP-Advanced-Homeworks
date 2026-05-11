

namespace Class02.HomeWorkTask3.Models;

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double CalculateArea()
    {
        Console.WriteLine("Rectangle Area:");
        return Width * Height;
    }

    public override double CalculatePerimeter()
    {
        Console.WriteLine("Rectangle Perimeter");
        return 2 * (Width + Height);
    }
}
