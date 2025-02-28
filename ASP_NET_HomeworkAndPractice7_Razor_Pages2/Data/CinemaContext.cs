using ASP_NET_HomeworkAndPractice7_Razor_Pages2.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_NET_HomeworkAndPractice8_Razor_Pages3.Data
{
    public class CinemaContext : DbContext
    {
        public CinemaContext(DbContextOptions<CinemaContext> options):
            base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
