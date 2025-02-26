


namespace ASP_NET_HomeworkAndPractice7_Razor_Pages2.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; } = default!;
        
        public string Director { get; set; } = default!;

        public string Style { get; set; } = default!;

        public string Description { get; set; } = default!;

        public string Sessions { get; set; } = default!;
    }
}
