using ASP_NET_HomeworkAndPractice7_Razor_Pages2.Models;
using ASP_NET_HomeworkAndPractice7_Razor_Pages2.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_NET_HomeworkAndPractice7_Razor_Pages2.Pages.Movies
{
    //[IgnoreAntiforgeryToken]

    public class Create1Model : PageModel
    {
        private IMovieRepository repository;

        public Create1Model(IMovieRepository repository)
        {
            this.repository = repository;
        }

        [BindProperty]
        public Movie Movie { get; set; } = new();
        public IMovieRepository Repository { get; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid && Movie is not null)
            {
                repository.Create(Movie);
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
