

namespace Class03.HomeworkTask1.Models;

public static class UserDatabase
{
    public static List<User> Users { get; set; } = new List<User>();


    public static string SearchById(int id)
    {
        foreach (var user in Users)
        {
            if (user.Id == id)

                return $"Name:{user.Name} Age:{user.Age}";
        }

        return null;
        
    }

    public static List<User> SearchByName(string name)
    {
        List<User> result = new List<User>();
        foreach (var user in Users)
        {
            if (user.Name == name) 
            {
                result.Add(user);
            }
        }

        return result;
    }


    public static List<User> SearchByAge(int age)
    {
        List<User> result = new List<User>();
        foreach (var user in Users)
        {
            if(user.Age == age)
            {
               result.Add(user);
            }
        }

        return result;
    }

};
