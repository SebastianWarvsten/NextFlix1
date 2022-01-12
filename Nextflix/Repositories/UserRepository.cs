using System;
using System.Collections.Generic;
using System.Linq;
using Nextflix.Controllers;
using Nextflix.Entities;

namespace Nextflix.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> _userCollection = new List<User>()
        {
            new User() { id = 1, userName = "jimmy", userEmail = "j@live.se" }
        };

        public IEnumerable<User> GetUsers()
        {
            return _userCollection;
        }

        public void CreateUser(User user)
        {
            _userCollection.Add(user);
        }

        public void DeleteUser(int id)
        {
            User index = _userCollection.Find(e => e.id == id);
            _userCollection.Remove(index);
        }

        public User GetUser(int id)
        {
            var director = _userCollection.Where(item => item.id == id);
            return director.SingleOrDefault();
        }

        public void UpdateUser(User user)
        {
            var index = _userCollection.FindIndex(e => e.id == user.id);
            _userCollection[index] = user;
        }
    }
}
