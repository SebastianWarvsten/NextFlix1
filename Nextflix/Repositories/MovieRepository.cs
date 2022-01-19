using Nextflix.Controllers;
using Nextflix.Data;
using Nextflix.Entities;
using Nextflix.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Nextflix.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _context;

        public MovieRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void CreateMovie(Movie movie)
        {
            _context.Movie.Add(movie);
            _context.SaveChanges();
        }

        public void DeleteMovie(Movie movie)
        {
            _context.Movie.Remove(movie);
            _context.SaveChanges();
        }

        public Movie GetMovie(int id)
        {
            return _context.Movie.Where(item => item.id == id).FirstOrDefault();

        }

        public IEnumerable<Movie> GetMovies()
        {
            return _context.Movie;
        }

        public void UpdateMovie(Movie movie)
        {
            _context.Update(movie);
            _context.SaveChanges();
        }
    }
}