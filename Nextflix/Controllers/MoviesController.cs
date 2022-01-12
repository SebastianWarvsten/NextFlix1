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

        public MoviesController(IMovieRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Movie> GetMovies() { return _repository.GetMovies(); }
    }
}