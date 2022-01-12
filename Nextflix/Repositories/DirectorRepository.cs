using System;
using System.Collections.Generic;
using System.Linq;
using Nextflix.Entities;

namespace Nextflix.Repositories
{
    public class DirectorRepository : IDirectorRepository
    {
        private readonly List<Director> _directorCollection = new List<Director>()
        {
            new Director() { id = 1, firstName = "Albert", lastName = "Andersson"},
            new Director() { id = 2, firstName = "Boris", lastName = "Boqvist"},
            new Director() { id = 3, firstName = "Cecar", lastName = "Cellberg"},
        };

        public IEnumerable<Director> GetDirectors()
        {
            return _directorCollection;
        }

        public Director GetDirector(int id)
        {
            var director = _directorCollection.Where(item => item.id == id);
            return director.SingleOrDefault();
        }

        public void AddDirector(Director director)
        {
            _directorCollection.Add(director);
        }

        public void DeleteDirector(int id)
        {
            Director index = _directorCollection.Find(e => e.id == id);
            _directorCollection.Remove(index);
        }

        public void UpdateDirector(Director director)
        {
            var index = _directorCollection.FindIndex(e => e.id == director.id);
            _directorCollection[index] = director;
        }
    }
}
