
namespace Class03.HomeworkTask2.Models;

public class Car : Vehicle
{
    public Car()
    {
        Type = "car";
        Wheels = "4";
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Im a {Type} and i drive on {Wheels} wheels");
    }
}
