
using Class02.Homework.Domain.Models;

Document doc = new Document("My title", "Hello world");
WeBPage page = new WeBPage("https://www.google.com/", "<b>This text is bold</b>");

Console.WriteLine(doc.Search("world"));
Console.WriteLine(page.Search("bold"));
