using System;
using System.Collections.Generic;
using Nextflix.Entities;

namespace Nextflix.Repositories
{
    public interface IDirectorRepository
    {
        IEnumerable<Director> GetDirectors();

        Director GetDirector(int id);
        void AddDirector(Director director);
        void DeleteDirector(int id);
        void UpdateDirector(Director director);
    }
}
