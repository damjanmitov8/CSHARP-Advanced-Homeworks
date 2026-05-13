

namespace Class03.HomeworkTask2.Models;

public class Boat : Vehicle
{
    public Boat()
    {
        Type = "boat";
        Wheels = "i do not have wheels";
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Im {Type} and {Wheels}");
    }
}
