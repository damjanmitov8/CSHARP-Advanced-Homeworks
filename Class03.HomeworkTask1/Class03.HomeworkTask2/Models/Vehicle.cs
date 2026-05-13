

namespace Class03.HomeworkTask2.Models;

public abstract class Vehicle
{
    public string Type { get; set; }
    public string Wheels { get; set; }

    public abstract void DisplayInfo();
    
}
