using System;
using System.Collections.Generic;
using Nextflix.Entities;

namespace Nextflix.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        User GetUser(int id);
        void UpdateUser(User user);
        void CreateUser(User user);
        void DeleteUser(int id);
    }
}
