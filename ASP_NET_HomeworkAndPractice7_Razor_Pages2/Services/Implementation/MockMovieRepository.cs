using ASP_NET_HomeworkAndPractice7_Razor_Pages2.Models;
using ASP_NET_HomeworkAndPractice7_Razor_Pages2.Services.Abstract;

namespace ASP_NET_HomeworkAndPractice7_Razor_Pages2.Services.Implementation
{
    public class MockMovieRepository : IMovieRepository
    {
        private ICollection<Movie> _movies;

        public MockMovieRepository()
        {
            _movies = new List<Movie>();
        }

        public Movie Create(Movie entity)
        {
            int newId = 0;
            if (_movies.Count > 0)
            {
                newId = _movies.Max(t => t.Id);
            }
            entity.Id = ++newId;
            _movies.Add(entity);
            return entity;
        }

        public Movie? Delete(int id)
        {
            Movie? movie = _movies.FirstOrDefault(t => t.Id == id);
            if (movie != null)
                _movies.Remove(movie);
            return movie;
        }

        public Movie Edit(Movie entity)
        {
            Movie? editedMovie = _movies
                .FirstOrDefault(t => t.Id == entity.Id);
            if (editedMovie != null)
            {
                editedMovie.Title = entity.Title;
                editedMovie.Director = entity.Director;
                editedMovie.Sessions = entity.Sessions;
                editedMovie.Style = entity.Style;
                editedMovie.Description = entity.Description;
                return editedMovie;
            }
            else
                return entity;
        }

        public Movie? Get(int id)
        {
            Movie? movie = _movies
                .FirstOrDefault(t => t.Id == id);
            return movie;
        }

        public IEnumerable<Movie> GetAll()
        {
            return _movies.ToList();
        }
    }
}
