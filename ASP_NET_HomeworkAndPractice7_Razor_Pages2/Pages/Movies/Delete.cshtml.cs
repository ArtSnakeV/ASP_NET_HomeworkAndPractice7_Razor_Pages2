using ASP_NET_HomeworkAndPractice7_Razor_Pages2.Models;
using ASP_NET_HomeworkAndPractice7_Razor_Pages2.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_NET_HomeworkAndPractice8_Razor_Pages3.Pages.Movies
{
    [IgnoreAntiforgeryToken]
    public class DeleteModel : PageModel
    {
        private readonly IMovieRepository repository;

        public DeleteModel(IMovieRepository repository)
        {
            this.repository = repository;
        }

        [BindProperty]
        public Movie Movie { get; set; } = new();
        
        
        public void OnGet(int id)
        {
            Movie? movie = repository.Get(id);
            if(movie is not null)
            {
                Movie = movie;
            }

        }

        public IActionResult OnPost(int id)
        {
            Movie? movie = repository.Delete(id);
            return RedirectToPage("Index");
        }
    }
}
