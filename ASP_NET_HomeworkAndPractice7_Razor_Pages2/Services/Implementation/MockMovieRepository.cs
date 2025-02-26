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

        public IEnumerable<Movie> GetAll()
        {
            return _movies.ToList();
        }
    }
}
