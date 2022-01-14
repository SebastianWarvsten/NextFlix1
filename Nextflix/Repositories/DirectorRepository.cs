using System;
using System.Collections.Generic;
using System.Linq;
using Nextflix.Data;
using Nextflix.Entities;

namespace Nextflix.Repositories
{
    public class DirectorRepository : IDirectorRepository
    {

        private readonly ApplicationDbContext _context;
        public DirectorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Director> GetDirectors()
        {
            return _context.Directors.ToList();
        }

        public Director GetDirector(int id)
        {
            return _context.Directors.Where(d => d.Id == id).FirstOrDefault();
        }

        public void AddDirector(Director director)
        {
            _context.Directors.Add(director);
            _context.SaveChanges();
        }

        public void DeleteDirector(int id)
        {
            var director = _context.Directors.Where(d => d.Id == id).FirstOrDefault();
            _context.Remove(director);
            _context.SaveChanges();
        }

        public void UpdateDirector(Director director)
        {
            //var index = _context.Directors.Where(e => e.id == director.id);
            //_context.Update(index);
            //var director = _context.Directors.Where(d => d.Id == id).FirstOrDefault();
            _context.Update(director);
            _context.SaveChanges();
        }
        //private readonly List<Director> _directorCollection = new List<Director>()
        //{
        //    new Director() { id = 1, firstName = "Albert", lastName = "Andersson"},
        //    new Director() { id = 2, firstName = "Boris", lastName = "Boqvist"},
        //    new Director() { id = 3, firstName = "Cecar", lastName = "Cellberg"},
        //};

        //public IEnumerable<Director> GetDirectors()
        //{
        //    return _directorCollection;
        //}

        //public Director GetDirector(int id)
        //{
        //    var director = _directorCollection.Where(item => item.id == id);
        //    return director.SingleOrDefault();
        //}

        //public void AddDirector(Director director)
        //{
        //    _directorCollection.Add(director);
        //}

        //public void DeleteDirector(Director director)
        //{
        //    //Director index = _directorCollection.Find(e => e.id == id);
        //    //_directorCollection.Remove(index);
        //    _directorCollection.Remove(director);
        //}

        //public void UpdateDirector(Director director)
        //{
        //    var index = _directorCollection.FindIndex(e => e.id == director.id);
        //    _directorCollection[index] = director;
        //}
    }
}
