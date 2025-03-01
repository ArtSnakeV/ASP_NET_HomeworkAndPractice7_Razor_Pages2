


using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_NET_HomeworkAndPractice7_Razor_Pages2.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [MinLength(1)]
        [Display(Name = "Movie title")]
        public string Title { get; set; } = default!;

        [Display(Name = "Director(s)")]
        public string Director { get; set; } = default!;

        [Display(Name = "Style(s)")]
        public string Style { get; set; } = default!;

        [Display(Name = "Description/details")]
        public string Description { get; set; } = default!;

        //Adding unusual name 
        [Display(Name = "Nearest sessions")]
        public string Sessions { get; set; } = default!;
    }
}
