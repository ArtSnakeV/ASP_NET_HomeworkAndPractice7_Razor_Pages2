using ASP_NET_HomeworkAndPractice7_Razor_Pages2.Models;
using ASP_NET_HomeworkAndPractice7_Razor_Pages2.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_NET_HomeworkAndPractice7_Razor_Pages2.Pages.Movies
{
    [IgnoreAntiforgeryToken]
    public class IndexModel : PageModel
    {
        private readonly IMovieRepository repository;

        public IEnumerable<Movie> Movies { get; set; }

        public IndexModel(IMovieRepository repository)
        {
            Movies = repository.GetAll();
            this.repository = repository;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost(int? id)
        {
            if (id is null)
                return NotFound();
            Movie? author = repository.Get(id.Value);
            if (author == null)
                return NotFound();
            // Deleting if found
            repository.Delete(id.Value);
            //return Page();
            return RedirectToPage("Index");
        }
    }
}
