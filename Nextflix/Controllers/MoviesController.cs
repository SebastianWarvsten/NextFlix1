using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nextflix.Repositories;
using Nextflix.Controllers;
using Nextflix.Entities;
using System.Collections.Generic;

namespace Nextflix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieRepository _repository;

        // private readonly IReviewRepository _revRepository;
        

        public MoviesController(IMovieRepository repository) { _repository = repository; }

        [HttpGet]
        public IEnumerable<Movie> GetMovies() { return _repository.GetMovies(); }

        [HttpGet("{id}")]
        public ActionResult<Movie> GetMovie(int id) 
        {
            var movie = _repository.GetMovie(id);

            if (movie == null)
            {
                return NotFound();
            }
            return Ok(movie);
        }

        [HttpPut("{id}")]
        public ActionResult<Movie> UpdateMovie([FromBody] Movie movie, int id)
        {
            var existingMovie = _repository.GetMovie(id);
            if (existingMovie == null)
            {
                return NotFound();
            }
            existingMovie.Id = movie.Id;
            existingMovie.Title = movie.Title;
            existingMovie.Description = movie.Description;
            existingMovie.ReleaseDate = movie.ReleaseDate;
            existingMovie.DirectorID = movie.DirectorID;
            existingMovie.Category = movie.Category;

            _repository.UpdateMovie(existingMovie);

            return Ok(existingMovie);
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteMovie(int id)
        {
            _repository.DeleteMovie(_repository.GetMovie(id));
            return NoContent();
        }
        [HttpPost]
        public void CreateMovie([FromBody] Movie movie)
        {
            _repository.CreateMovie(movie);
        }
    }
}