using Class02.HomeworkTask4.Models;

Employee[] employees = new Employee[]
{
    new Manager("Ana", 1, 5000, 1000),
    new Programmer("Marko", 2, 20, 160)
};

foreach (var emp in employees)
{
    emp.DisplayInfo();
    Console.WriteLine("---------------");
}