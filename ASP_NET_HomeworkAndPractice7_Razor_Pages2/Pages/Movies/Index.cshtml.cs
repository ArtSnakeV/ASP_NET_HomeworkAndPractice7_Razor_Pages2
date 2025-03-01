using ASP_NET_HomeworkAndPractice7_Razor_Pages2.Models;
using ASP_NET_HomeworkAndPractice7_Razor_Pages2.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_NET_HomeworkAndPractice7_Razor_Pages2.Pages.Movies
{
    //[IgnoreAntiforgeryToken]
    public class IndexModel : PageModel
    {
        private readonly IMovieRepository repository;

        [BindProperty(SupportsGet = true)]
        public string? TitleSearch { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? DirectorSearch { get; set; }

        public IEnumerable<Movie> Movies { get; set; }

        public IndexModel(IMovieRepository repository)
        {
            Movies = repository.GetAll();
            this.repository = repository;
        }

        // OnGet we are using for the search
        //public void OnGet(string? titleSearch, string directorSearch)
        //{
        //    Movies = repository.GetAll();
        //    if (!string.IsNullOrEmpty(titleSearch))
        //    {
        //        Movies = Movies.Where(t => t.Title.Contains(titleSearch));
        //    }
        //    if (!string.IsNullOrEmpty(directorSearch))
        //    {
        //        Movies = Movies.Where(t => t.Director.Contains(directorSearch));
        //    }
        //}
        public void OnGet()
        {
            Movies = repository.GetAll();
            if (!string.IsNullOrEmpty(TitleSearch))
            {
                Movies = Movies.Where(t => t.Title.Contains(TitleSearch));
            }
            if (!string.IsNullOrEmpty(DirectorSearch))
            {
                Movies = Movies.Where(t => t.Director.Contains(DirectorSearch));
            }
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
