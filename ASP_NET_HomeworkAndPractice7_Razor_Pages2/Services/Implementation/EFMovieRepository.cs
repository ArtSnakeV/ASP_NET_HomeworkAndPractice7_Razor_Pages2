using ASP_NET_HomeworkAndPractice7_Razor_Pages2.Models;
using ASP_NET_HomeworkAndPractice7_Razor_Pages2.Services.Abstract;
using ASP_NET_HomeworkAndPractice8_Razor_Pages3.Data;

namespace ASP_NET_HomeworkAndPractice8_Razor_Pages3.Services.Implementation
{
    public class EFMovieRepository : IMovieRepository
    {
        private readonly CinemaContext context;

        public EFMovieRepository(CinemaContext context)
        {
            this.context = context;
        }

        Movie IRepository<Movie>.Create(Movie entity)
        {
            context.Movies.Add(entity);
            context.SaveChanges();
            return entity;
        }

        Movie? IRepository<Movie>.Delete(int id)
        {
            Movie? movie = context.Movies.Find(id);
            if(movie is not null)
            {
                context.Movies.Remove(movie);
                context.SaveChanges();
            }
            return movie;
        }

        Movie IRepository<Movie>.Edit(Movie entity)
        {
            Movie? editedMovie = context.Movies.Find(entity.Id);
            if(editedMovie is not null)
            {
                editedMovie.Title = entity.Title;
                editedMovie.Director = entity.Director;
                editedMovie.Sessions = entity.Sessions;
                editedMovie.Description = entity.Description;
                editedMovie.Sessions = entity.Sessions;
                context.SaveChanges();
                return editedMovie;
            }
            return entity;
        }

        Movie? IRepository<Movie>.Get(int id)
        {
            Movie? movie = context.Movies.Find(id);
            return movie;
        }

        IEnumerable<Movie> IRepository<Movie>.GetAll()
        {
            return context.Movies.ToList();
        }
    }
}
