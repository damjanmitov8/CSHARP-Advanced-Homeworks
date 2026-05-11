

using Class02.HomeworkTask2.Domain.Interface;

namespace Class02.HomeworkTask2.Domain.Models;

public class Triangle : IShape
{
    public double Base { get; set; }
    public double Height { get; set; }
    public double   Area { get { return 0.5 * Base * Height; } }

    public Triangle(double basee, double height)
    {
        Base = basee;
        Height = height;
    }


    public double GetArea()
    {
        return Area;
    }
}
