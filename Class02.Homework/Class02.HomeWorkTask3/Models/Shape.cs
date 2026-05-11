

namespace Class02.HomeWorkTask3.Models;

public abstract class Shape
{
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();

    public void DisplayInfo()
    {
        Console.WriteLine(CalculateArea());
        Console.WriteLine(CalculatePerimeter());
    } 
}
