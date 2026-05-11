
using Class02.HomeworkTask2.Domain.Interface;

namespace Class02.HomeworkTask2.Domain.Models;

public class Circle : IShape
{
    public double Radius { get; set; }
    public double Area { get { return Math.PI * Math.Pow(Radius, 2); } }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double GetArea()
    {
        return Area;
    }
}
