

using Class02.Homework.Domain.Interfaces;
using System.Text.RegularExpressions;

namespace Class02.Homework.Domain.Models;

public class WeBPage : ISearchable
{
    public string Url { get; set; }
    public string Html { get; set; }

    public WeBPage(string url,string html)
    {
        Url = url;
        Html = html;
    }

    public bool Search(string word)
    {
        string cleanHtml = Regex.Replace(Html, "<.*?>", "");
        return cleanHtml.ToLower().Contains(word.ToLower());
    }
}
