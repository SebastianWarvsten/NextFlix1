using Nextflix.Entities;
using System.Collections.Generic;

namespace Nextflix.Controllers
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> GetMovies();
        Movie GetMovie(int id);
        void UpdateMovie(Movie movie);
        void CreateMovie(Movie movie);
        void DeleteMovie(Movie movie);
    }
}