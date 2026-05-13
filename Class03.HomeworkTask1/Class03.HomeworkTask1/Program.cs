
using Class03.HomeworkTask1.Models;

UserDatabase.Users.Add(new User { Id = 1, Age = 23, Name = "Bob" });
UserDatabase.Users.Add(new User { Id = 2, Age = 23, Name = "John" });
UserDatabase.Users.Add(new User { Id = 3, Age = 43, Name = "Joe" });
UserDatabase.Users.Add(new User { Id = 4, Age = 33, Name = "Joe" });

Console.WriteLine("=== Search by Id ===");
Console.WriteLine(UserDatabase.SearchById(1));
Console.WriteLine("=== Search by name ===");
var usersByName = UserDatabase.SearchByName("Joe");
foreach (var user in usersByName)
{
    Console.WriteLine($"Id:{user.Id}, Age:{user.Age}");
}

Console.WriteLine("=== Search by age ===");
var usersByAge = UserDatabase.SearchByAge(23);
foreach (var user in usersByAge)
{
    Console.WriteLine($"Name:{user.Name}, Id:{user.Id}");
}