using ASP_NET_HomeworkAndPractice7_Razor_Pages2.Models;
using ASP_NET_HomeworkAndPractice7_Razor_Pages2.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_NET_HomeworkAndPractice7_Razor_Pages2.Pages.Movies
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Movie> Movies { get; set; }

        public IndexModel(IMovieRepository repository)
        {
            Movies = repository.GetAll();
        }

        public void OnGet()
        {
        }
    }
}
