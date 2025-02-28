using ASP_NET_HomeworkAndPractice7_Razor_Pages2.Models;
using ASP_NET_HomeworkAndPractice7_Razor_Pages2.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_NET_HomeworkAndPractice8_Razor_Pages3.Pages.Movies
{
    [IgnoreAntiforgeryToken]
    public class EditModel : PageModel
    {
        private IMovieRepository repository;

        //public string Message { get; set; } = "";

        [BindProperty]
        public Movie Movie { get; set; } = new();
        
         
        public EditModel(IMovieRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult OnGet(int id)
        {
            //Message = $"You set Id: {id}";
            Movie? movie = repository.Get(id);
            if(movie is not null)
            {
                Movie = movie;
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            repository.Edit(Movie);
            return RedirectToPage("Index");
        }
    }
}
