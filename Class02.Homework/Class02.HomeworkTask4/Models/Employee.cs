

namespace Class02.HomeworkTask4.Models;

public abstract class Employee
{
    public string Name { get; set; }
    public int Id { get; set; }

    public Employee(string name, int id)
    {
        Name = name;
        Id = id;
    }

    public abstract decimal CalculateSalary();
    public abstract void DisplayInfo();
}
