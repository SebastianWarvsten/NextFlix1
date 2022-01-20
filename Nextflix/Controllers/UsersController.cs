using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Nextflix.Entities;
using Nextflix.Repositories;

namespace Nextflix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserRepository _repository;

        public UsersController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            return _repository.GetUsers();
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            var user = _repository.GetUser(id);

            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost]
        public ActionResult<User> CreateUser(User user)
        {
            User nUser = new User()
            {
                Id = user.Id,
                UserName = user.UserName,
                UserEmail = user.UserEmail,
            };
            _repository.CreateUser(user);
            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteUser(int id)
        {
            _repository.DeleteUser(id);
            return NoContent();
        }

        [HttpPut("{id}")]
        public ActionResult UpdateUser(User user, int id)
        {
            var selectedUser = _repository.GetUser(id);
            if (selectedUser == null)
            {
                return NotFound();
            }
            selectedUser.UserName = user.UserName;
            selectedUser.UserEmail = user.UserEmail;
            _repository.UpdateUser(selectedUser);
            return Ok();
        }
    }

}
