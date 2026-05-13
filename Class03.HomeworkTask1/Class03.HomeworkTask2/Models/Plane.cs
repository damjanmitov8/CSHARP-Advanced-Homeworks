

namespace Class03.HomeworkTask2.Models;

public class Plane : Vehicle
{
    public Plane()
    {
        Type = "plane";
        Wheels = "i have couple of wheels";
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Im {Type} and {Wheels}");
    }
}
