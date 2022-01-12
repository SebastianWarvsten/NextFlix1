using Nextflix.Controllers;
using Nextflix.Entities;
using Nextflix.Repositories;
using System.Collections.Generic;

namespace Nextflix.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly List<Movie> _movieCollection = new List<Movie>() { new Movie() { id = 1, title = "Avatar", description = "Humans vs Aliens", directorId = 1 } };
        public void CreateMovie(Movie movie)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteMovie(Movie movie)
        {
            throw new System.NotImplementedException();
        }

        public Movie GetMovie(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Movie> GetMovies()
        {
            return _movieCollection;
        }

        public void UpdateMovie(Movie movie)
        {
            throw new System.NotImplementedException();
        }
    }
}