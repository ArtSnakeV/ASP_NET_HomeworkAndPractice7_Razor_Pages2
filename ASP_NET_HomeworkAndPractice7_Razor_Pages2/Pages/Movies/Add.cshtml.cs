using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace ASP_NET_HomeworkAndPractice7_Razor_Pages2.Pages.Movies
{
    [IgnoreAntiforgeryToken]
    public class AddModel : PageModel
    {
        [BindProperty]
        [MinLength(1)]
        public string Title { get; set; } = "";
        [BindProperty]
        [MinLength(1)]
        public string Director { get; set; } = "";
        [BindProperty]
        [MinLength(3)]
        public string Style { get; set; } = "";
        [BindProperty]
        [MinLength(5)]
        public string Description { get; set; } = "";
        [BindProperty]
        [MinLength(1)]
        public string Sessions { get; set; } = "";

        public IList<string>? ErrorMessages { get; set; }

        public void OnGet()
        {
            ViewData["Title"] = "Adding movie";
        }

        public void OnPost(string title, string director, string style, string description, string sessions)
        {
            if (!ModelState.IsValid)
            {
                ErrorMessages = new List<string>();
                foreach (var state in ModelState)
                {
                    foreach (var error in state.Value.Errors)
                        ErrorMessages.Add(error.ErrorMessage);
                }
            }
            else
                ErrorMessages = null;
            //Message = $"Following movie added:";
            //Title = $"{title}";
            //Director = $"{director}";
            //Style = $"{style}";
            //Description = $"{description}";
            //Sessions = $"{sessions}";
        }
    }
}
