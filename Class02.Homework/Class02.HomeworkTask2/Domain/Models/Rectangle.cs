
using Class02.HomeworkTask2.Domain.Interface;

namespace Class02.HomeworkTask2.Domain.Models;

public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public double Area { get { return Width * Height; } }

    public Rectangle(double width,double height)
    {
        Width = width;
        Height = height;
    }

    public double GetArea()
    {
        return Area;
    }

}
