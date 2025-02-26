using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;

namespace ASP_NET_HomeworkAndPractice7_Razor_Pages2.Pages.Movies
{
    [IgnoreAntiforgeryToken]
    public class CreateModel : PageModel
    {
        public string Message { get; set; } = "";

        public void OnGet()
        {
            ViewData["Title"] = "Adding movie";
        }

        public void OnPost(string title, string director, string style, string description, string sessions)
        {
            
            Message = $"<h1>New movie added with following values:</h1>" +
                $"<div>Title: {title}</div>" +
                $"<div>Director: {director}</div>" +
                $"<div>Style: {style}</div>" +
                $"<div>Description: {description}</div>" +
                $"<div>Sessions: {sessions}</div>" +
                $"</h1><br/>";
        }
    }
}
