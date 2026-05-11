
namespace Class02.HomeWorkTask3.Models;

public class Circle : Shape
{
    public double Radius { get; set; }

    public override double CalculatePerimeter()
    {
        Console.WriteLine("Circle Perimeter:");
        return 2 * Math.PI * Radius;
    }

    public override double CalculateArea()
    {
        Console.WriteLine("Circle Area:");
        return Math.PI * Math.Pow(Radius, 2);
    }
}
