

namespace Class02.HomeWorkTask3.Models;

public class Triangle : Shape
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public Triangle(double sideA , double sideB,double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public override double CalculateArea()
    {
        Console.WriteLine("Triangle Area:");
        double s = (SideA + SideB + SideC) / 2;

        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    public override double CalculatePerimeter()
    {
        Console.WriteLine("Triangle Perimeter:");
        return SideA + SideB + SideC;
    }
}
