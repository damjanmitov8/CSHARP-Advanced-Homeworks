
using Class02.Homework.Domain.Interfaces;

namespace Class02.Homework.Domain.Models;

public class Document : ISearchable
{
    public string Title { get; set; }
    public string Content { get; set; }

    public Document(string title,string content)
    {
        Title = title;
        Content = content;
    }

    public bool Search(string word)
    {
        return Content.ToLower().Contains(word.ToLower());
    }
}
