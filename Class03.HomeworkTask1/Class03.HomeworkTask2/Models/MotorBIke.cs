

namespace Class03.HomeworkTask2.Models;

public class MotorBIke : Vehicle
{
    public MotorBIke()
    {
        Type = "motorbike";
        Wheels = "2";
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Im {Type} and i drive on {Wheels} wheels ");
    }
}
