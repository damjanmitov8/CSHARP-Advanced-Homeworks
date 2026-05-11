using Class02.HomeworkTask2.Domain.Interface;
using Class02.HomeworkTask2.Domain.Models;

IShape[] shapes = new IShape[]
{
    new Triangle(5, 5),
    new Circle(10),
    new Rectangle(10, 15)
};

foreach (var shape in shapes)
{
    Console.WriteLine(shape.GetArea());
}