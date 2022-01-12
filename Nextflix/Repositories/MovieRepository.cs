using Nextflix.Controllers;
using Nextflix.Entities;
using Nextflix.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Nextflix.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly List<Movie> _movieCollection = new List<Movie>() { new Movie() { id = 1, title = "Avatar", description = "Humans vs Aliens", directorId = 1, category = 0 } };
        public void CreateMovie(Movie movie)
        {
            _movieCollection.Add(new Movie() { id = movie.id, title = movie.title, description = movie.description, directorId = movie.directorId, category = movie.category });
        }

        public void DeleteMovie(Movie movie)
        {
            _movieCollection.Remove(movie);
        }

        public Movie GetMovie(int id)
        {
            return _movieCollection.Where(item => item.id == id).FirstOrDefault();
        }

        public IEnumerable<Movie> GetMovies()
        {
            return _movieCollection;
        }

        public void UpdateMovie(Movie movie)
        {
            var index = _movieCollection.FindIndex(existingMovie => existingMovie.id == movie.id);
        }
    }
}