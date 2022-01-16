using System.Collections.Generic;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Nextflix.Entities;
using Nextflix.Repositories;

namespace Nextflix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorsController : ControllerBase
    {
        private readonly IDirectorRepository _repository;

        public DirectorsController(IDirectorRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]

        public IEnumerable<Director> GetDirectors()
        {
            return _repository.GetDirectors();
        }

        [HttpGet("{id}")]

        public ActionResult<Director> GetDirector(int id)
        {
            var director = _repository.GetDirector(id);

            if (director == null)
            {
                return NotFound();
            }
            return Ok(director);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateDirector(Director director, int id)
        {
            var selectedDirector = _repository.GetDirector(id);
            if (selectedDirector == null)
            {
                return NotFound();
            }
            selectedDirector.firstName = director.firstName;
            selectedDirector.lastName = director.lastName;
            _repository.UpdateDirector(selectedDirector);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteDirector(int id)
        {
            _repository.DeleteDirector(id);
            return NoContent();
        }

        [HttpPost]
        public ActionResult<Director> AddDog(Director director)
        {
            Director nDirector = new Director()
            {
                Id = director.Id,
                firstName = director.firstName,
                lastName = director.lastName,
            };
            _repository.AddDirector(director);
            return CreatedAtAction(nameof(GetDirector), new { Id = director.Id }, director);
        }
    }
}